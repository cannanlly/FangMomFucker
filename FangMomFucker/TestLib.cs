using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Security;
using System.Threading;
using System.Net.Sockets;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.IO;

namespace FangMomFucker
{
    class TestLib
    {
        private static int legalThrs;
        private static Thread[] testThreadings;
        private static Stack<uint> randStack;
        private static Stack<object[]> stdStack;

        public static bool running = false;
        public static bool stopped = true;
        public static int thrs;
        public static int times;
        public static int timeOut;
        public static int remainder;

        public static Stack<object[]> cache = new Stack<object[]>(100000);
        public static List<uint> randPool = new List<uint>();
        public static List<object[]> stdPool = new List<object[]>();

        private static  uint ToBigEnd(uint temp)
        {
            uint temp2 = 0;
            temp2 |= (temp & 0xFF) << 24;
            temp2 |= (temp & 0xFF00) << 8;
            temp2 |= (temp & 0xFF0000) >> 8;
            temp2 |= (temp & 0xFF000000) >> 24;
            return temp2;
        }
        private static List<uint> CIDRtoIpList(string cidrIP)
        {
            try
            {
                string[] split = cidrIP.Split('/');
                string[] ipSeg = split[0].Split('.');
                uint start = Convert.ToUInt32(ipSeg[0]) * 16777216 +
                    Convert.ToUInt32(ipSeg[1]) * 65536 +
                    Convert.ToUInt32(ipSeg[2]) * 256 +
                    Convert.ToUInt32(ipSeg[3]);
                uint count = Convert.ToUInt32(split[1]);
                count = (uint)Math.Pow(2, (32 - count));

                List<uint> temp = new List<uint>((int)count);
                for (uint i = 0; i < count; i++)
                {
                    temp.Add(ToBigEnd(start + i));
                }
                return temp;
            }
            catch
            {
                return new List<uint>();
            }
        }
        private static List<uint> IpRangetoIpList(string ipStr)
        {
            List<uint> nullList = new List<uint>();
            try
            {
                List<uint> temp = new List<uint>();
                string[] ipSeg = ipStr.Split('.');
                uint a1, a2, b1, b2, c1, c2, d1, d2;
                if (IsRange(ipSeg[0]))
                {
                    uint[] tempUint = splitRange(ipSeg[0]);
                    a1 = tempUint[0];
                    a2 = tempUint[1];
                    if (a1 > 255 || a2 > 255)
                        return nullList;
                }
                else
                {
                    a1 = a2 = Convert.ToUInt32(ipSeg[0]);
                }
                if (IsRange(ipSeg[1]))
                {
                    uint[] tempUint = splitRange(ipSeg[1]);
                    b1 = tempUint[0];
                    b2 = tempUint[1];
                    if (b1 > 255 || b2 > 255)
                        return nullList;
                }
                else
                {
                    b1 = b2 = Convert.ToUInt32(ipSeg[1]);
                }
                if (IsRange(ipSeg[2]))
                {
                    uint[] tempUint = splitRange(ipSeg[2]);
                    c1 = tempUint[0];
                    c2 = tempUint[1];
                    if (c1 > 255 || c2 > 255)
                        return nullList;
                }
                else
                {
                    c1 = c2 = Convert.ToUInt32(ipSeg[2]);
                }
                if (IsRange(ipSeg[3]))
                {
                    uint[] tempUint = splitRange(ipSeg[3]);
                    d1 = tempUint[0];
                    d2 = tempUint[1];
                    if (d1 > 255 || d2 > 255)
                        return nullList;
                }
                else
                {
                    d1 = d2 = Convert.ToUInt32(ipSeg[3]);
                }
                for (uint a = a1; a <= a2; a++)
                    for (uint b = b1; b <= b2; b++)
                        for (uint c = c1; c <= c2; c++)
                            for (uint d = d1; d <= d2; d++)
                                temp.Add(d * 16777216 +
                                    c * 65536 +
                                    b * 256 +
                                    a);
                return temp;
            }
            catch
            {
                return nullList;
            }
        }
        private static bool IsRange(string str)
        {
            if (str.Split('-').Length >= 2)
                return true;
            else
                return false;
        }
        private static bool IsCIDR(string str)
        {
            if (str.Split('/').Length == 2)
                return true;
            else
                return false;
        }
        private static uint[] splitRange(string str)
        {
            string[] tempStr = str.Split('-');
            uint[] tempUint = new uint[2];
            tempUint[0] = Convert.ToUInt32(tempStr[0]);
            tempUint[1] = Convert.ToUInt32(tempStr[1]);
            return tempUint;
        }

        private static void TryAddIP(string str)
        {
            try
            {
                string[] tempStrs = str.Split('.');
                if (tempStrs.Length != 4)
                    return;
                uint a, b, c, d;
                a = Convert.ToUInt32(tempStrs[0]);
                b = Convert.ToUInt32(tempStrs[1]);
                c = Convert.ToUInt32(tempStrs[2]);
                d = Convert.ToUInt32(tempStrs[3]);
                if (a > 255U || b > 255U || c > 255U || d > 255U)
                    return;
                uint uintIP = a +
                    b * 256U +
                    c * 65536U +
                    d * 16777216U;
                randPool.Add(uintIP);
            }
            catch(Exception)
            {
            }
            remainder = randPool.Count;
        }
        public static void AddIPS(string str)
        {
            string[] tempStrs = str.Split("\r\n\t |".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            foreach (string temp in tempStrs)
            {
                if (IsCIDR(temp))
                {
                    randPool.AddRange(CIDRtoIpList(temp));
                }
                else if (IsRange(temp))
                {
                    randPool.AddRange(IpRangetoIpList(temp));
                }
                else
                {
                    TryAddIP(temp);
                }
            }
            remainder = randPool.Count;
        }

        private static void readyRandTest()
        {
            randPool = randPool.Distinct<uint>().ToList<uint>();
            mixRandPool();
            randStack = new Stack<uint>(randPool);
            randPool.Clear();
            if (thrs > randStack.Count)
                legalThrs = randStack.Count;
            else
                legalThrs = thrs;
        }
        private static void mixRandPool()
        {
            Random rr = new Random();
            int rand;
            uint temp;
            for (int i = 0; i < randPool.Count; i++)
            {
                rand = rr.Next(randPool.Count);
                temp = randPool[i];
                randPool[i] = randPool[rand];
                randPool[rand] = temp;
            }
        }
        private static void randTestSingle()
        {
            while (running)
            {
                Monitor.Enter(randStack);
                if(randStack.Count == 0)
                {
                    Monitor.Exit(randStack);
                    return;
                }
                uint ip = randStack.Pop();
                remainder = randStack.Count;
                Monitor.Exit(randStack);
                IPAddress IP = new IPAddress(ip);
                TcpClient tcp = new TcpClient();
                tcp.ReceiveTimeout = 1000;
                tcp.SendTimeout = 1000;
                try
                {
                    Ping pp = new Ping();
                    PingReply rep = pp.Send(IP, 1000);
                    if (rep.Status == IPStatus.Success)
                    {
                        if (rep.RoundtripTime > timeOut)
                            continue;
                        tcp.Connect(IP, 443);
                        SslStream ssl = new SslStream(tcp.GetStream(), false, (a, b, c, d) =>
                        {
                            string temp = Encoding.UTF8.GetString(b.GetRawCertData());
                            if (temp.IndexOf("google") != -1)
                                return true;
                            else
                                return false;
                        });
                        ssl.AuthenticateAsClient("");
                        StreamReader red = new StreamReader(ssl);
                        StreamWriter wrt = new StreamWriter(ssl);
                        wrt.Write("HEAD / HTTP/1.1\r\nHost:www.google.com\r\nConnection:Close\r\n\r\n");
                        wrt.Flush();
                        string report = red.ReadToEnd();
                        tcp.Close();
                        object[] info = new object[7];
                        if (report.IndexOf("Server: gvs 1.0") != -1)
                            info[2] = "GVS";
                        else if (report.IndexOf("Server: gws") != -1)
                            info[2] = "gws";
                        else
                            continue;
                        info[0] = IP.ToString();
                        info[1] = "_OK " + rep.RoundtripTime.ToString().PadLeft(4, '0');
                        info[3] = ssl.RemoteCertificate.Subject.Split(',')[0].Substring(3);
                        info[4] = "001";
                        info[5] = "";
                        info[6] = ip;
                        Monitor.Enter(cache);
                        cache.Push(info);
                        Monitor.Exit(cache);
                    }
                }
                catch (Exception)
                {
                    tcp.Close();
                }
                }
        }
        private static void stdTestSingle()
        {
            while (running)
            {
                Monitor.Enter(stdStack);
                if (stdStack.Count == 0)
                {
                    Monitor.Exit(stdStack);
                    return;
                }
                object[] info = stdStack.Pop();
                remainder = stdStack.Count;
                Monitor.Exit(stdStack);
                IPAddress IP = new IPAddress((uint)info[6]);
                info[1] = "_超时";
                info[4] = "000";
                int okINC = 0;
                Ping pp = new Ping();
                try
                {
                for(int i = 0; i < times;i++)
                {
                    PingReply rep =  pp.Send(IP,1000);
                    if(rep.Status == IPStatus.Success)
                    {
                        info[1] = "_OK " + rep.RoundtripTime.ToString().PadLeft(4,'0');
                        okINC++;   
                    }
                }
                info[4] = okINC.ToString().PadLeft(3, '0');
                }
                catch(Exception)
                {
                }
                finally
                {
                    Monitor.Enter(cache);
                    cache.Push(info);
                    Monitor.Exit(cache);
                }
            }
        }
        private static bool Isstopped()
        {
            foreach (Thread tt in testThreadings)
                if (tt.ThreadState != System.Threading.ThreadState.Stopped)
                    return false;
            return true;
        }

        public static void RandTest()
        {
            running = true;
            stopped = false;
            Thread check = new Thread(() =>
                {
                    readyRandTest();
                    testThreadings = new Thread[legalThrs];
                    for (int i = 0; i < testThreadings.Length; i++)
                    {
                        testThreadings[i] = new Thread(randTestSingle);
                        testThreadings[i].IsBackground = true;
                        testThreadings[i].Start();
                    }
                    while (true)
                    {
                        Thread.Sleep(100);
                        if (Isstopped())
                        {
                            running = false;
                            stopped = true;
                            return;
                        }
                    }
                });
            check.IsBackground = true;
            check.Start();
        }
        public static void StdTest()
        {
            running = true;
            stopped = false;
            Thread check = new Thread(() =>
            {

                stdPool = stdPool.Distinct<object[]>(new fuck()).ToList<object[]>();
                stdStack = new Stack<object[]>(stdPool);
                stdPool.Clear();
                if (stdStack.Count < thrs)
                    legalThrs = stdStack.Count;
                else
                    legalThrs = thrs;
                testThreadings = new Thread[legalThrs];
                for (int i = 0; i < testThreadings.Length; i++)
                {
                    testThreadings[i] = new Thread(stdTestSingle);
                    testThreadings[i].IsBackground = true;
                    testThreadings[i].Start();
                }
                while (true)
                {
                    Thread.Sleep(100);
                    if (Isstopped())
                    {
                        running = false;
                        stopped = true;
                        return;
                    }
                }
            });
            check.IsBackground = true;
            check.Start();
        }
        public static void BandTest()
        {
            running = true;
            stopped = false;
            testThreadings = new Thread[1];
            testThreadings[0] = new Thread(() =>
            {
                TestLib.stdPool = TestLib.stdPool.Distinct<object[]>(new fuck()).ToList<object[]>();
                for (int i = 0; i < stdPool.Count && running; i++)
                {
                    object[] temp = stdPool[i];
                    remainder = (stdPool.Count - i) - 1;
                    if (temp[2].ToString() == "GVS")
                    {
                        temp[5] = "无法测速";
                        Monitor.Enter(TestLib.cache);
                        TestLib.cache.Push(temp);
                        Monitor.Exit(TestLib.cache);
                        continue;
                    }
                    temp[5] = "0000_超时";
                    IPAddress ip = new IPAddress((uint)temp[6]);
                    TcpClient tcp = new TcpClient();
                    tcp.ReceiveTimeout = 1000;
                    tcp.SendTimeout = 1000;
                    try
                    {
                        tcp.Connect(ip, 443);
                        SslStream ssl = new SslStream(tcp.GetStream(),false,(a, b, c, d) =>true);
                        ssl.AuthenticateAsClient("");
                        StreamWriter wrt = new StreamWriter(ssl);
                        StreamReader red = new StreamReader(ssl);
                        Stopwatch watch = new Stopwatch();
                        wrt.Write("GET /YcIFP54LPdwLTk4aOOAkEcly-rJ0aPDqIvhUdeL-dOE=w1014-h498-no HTTP/1.1\r\nHost:lh3.googleusercontent.com\r\nConnection:close\r\n\r\n");
                        watch.Start();
                        wrt.Flush();
                        string rec = red.ReadToEnd();
                        watch.Stop();
                        tcp.Close();
                        if (rec.Length != 0)
                        {
                            temp[5] = ((int)(1238545 / 1024 / watch.Elapsed.TotalSeconds)).ToString().PadLeft(4, '0') + " KB/S";
                        }
                    }
                    catch (Exception)
                    {
                        tcp.Close();
                    }
                    finally
                    {
                        Monitor.Enter(TestLib.cache);
                        TestLib.cache.Push(temp);
                        Monitor.Exit(TestLib.cache);
                    }
                }
                running = false;
                stopped = true;
            });
            testThreadings[0].IsBackground = true;
            testThreadings[0].Start();
        }
        public class fuck:IEqualityComparer<object[]>
        {
            public bool Equals(object[] a, object[] b)
            {
                if ((uint)a[6] == (uint)b[6])
                    return true;
                else
                    return false;
            }
            public int GetHashCode(object[] obj)
            {
                return (int)((uint)obj[6]);
            }
        }
    }
}
