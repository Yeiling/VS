using System;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace NET_Path_File_Directory
{
    class Program
    {
        static void Main(string[] args)
        {
            //string guid = Guid.NewGuid().ToString("N");  ////tosting()参数可以是其他,如:B
            //Console.WriteLine(guid);

            //Upload(@"D:\TestFile", "g");

            //FileStream 是操作字节的
            #region
            //StreamReader和 StreamWriter是操作字符的
            //Copy(@"D:\WinPing.txt", @"C:\Documents and Settings\OS\桌面\winping_copy.txt");
            //CopyAll(@"D:\WinPing.txt", @"C:\Documents and Settings\OS\桌面\winping_copy.txt");
            #endregion

            //Path的用法
            #region path的操作
            //string filepath = @"D:\WinPing.txt";
            //Console.WriteLine(Path.GetDirectoryName(filepath));  //返回文件所在的文件夹
            //Console.WriteLine(Path.GetFileName(filepath));   //获取带有格式的文件名
            //Console.WriteLine(Path.GetFileNameWithoutExtension(filepath));  //返回不带有扩展名的文件名
            //Console.WriteLine(Path.GetExtension(filepath));    //返回文件的扩展名
            //Console.WriteLine(Path.GetFullPath(filepath));   //返回文件的绝对路径
            //Console.WriteLine(Path.GetPathRoot(filepath));   //获取文件的根目录        
            //Console.WriteLine(Path.HasExtension(filepath));  //确定路径是否包含扩展名

            //Console.WriteLine(Path.GetTempPath());     //获取系统的临时文件夹路径（缓存目录）
            ////Console.WriteLine(Path.GetTempFileName());  //在系统的临时文件路径下创建一个文件，并返回文件的绝对路径
            #endregion

            //Directory的用法
            #region directory的操作
            //string path = @"G:\";
            //创建目录（目录就是文件夹）
            //Directory.CreateDirectory(path + "\\" + "我的文件");
            //Console.WriteLine("创建目录OK");

            //Directory.Delete(path + "\\" + "我的文件");   //如果文件夹不是空的，则会报异常（不让删除）
            //Console.WriteLine("删除目录OK");
            //Directory.Delete(path + "\\" + "我的文件", true);//使用delete方法的另一个重载，递归删除即可
            //Console.WriteLine("递归删除目录OK");


            //move相当于“剪切”
            //当目标文件夹中已经存在相同的文件夹时会报错，移动文件夹不能跨磁盘
            //Directory.Move(path + "\\" + "我的文件", @"G:\1\我的文件");   //源路径和目标路径必须具有相同的根。移动操作在卷之间无效。
            //Console.WriteLine("移动文件夹OK");
            //move移动，相当于文件夹“重命名”（文件夹名称由1改成2）
            //Directory.Move(@"G:\1", @"G:\2");

            //文件夹的子文件
            //string path = @"G:\1\";
            ////string[] files = Directory.GetFiles(path); //直接子文件
            //string[] files = Directory.GetFiles(path, "*.txt", SearchOption.AllDirectories);  //GetFiles()方法的重载用法
            //foreach (string file in files)
            //{
            //    Console.WriteLine(file);
            //}
            //文件夹的子目录
            //string[] dire = Directory.GetDirectories(path);
            //foreach (string d in dire)
            //{
            //    Console.WriteLine(d);
            //}
            #endregion

            //file的用法
            //方法比较多，逐个测试


            //文件流 FileStream (流操作的是字节，而不是字符或者字符串)
            //string str = "hello world";
            //Hashtable ht = new Hashtable();
            //1:把字符串转换成char数组
            #region
            //char[] chr = str.ToCharArray();
            //foreach (char ch in chr)
            //{
            //    Console.WriteLine(ch);
            //}
            #endregion
            //1.1：把char[]数组转换成字符串
            #region
            //str = new string(chr);
            //Console.WriteLine(str);
            ////byte[] bbb = Encoding.Default.GetBytes(chr);  //根据chr字符数组获取字节数组
            #endregion
            //2:把字符串转换成字节数组
            #region
            //byte[] bt = Encoding.Default.GetBytes(str);
            //foreach (byte b in bt)
            //{
            //    Console.WriteLine(b);
            //}
            #endregion

            //使用文件流执行读写操作

            //写入字符串
            //文件流使用步骤：
            #region
            //string ms = "今天是个好日子，心想的事儿都能成。。。";
            ////A:创建文件流
            //FileStream fs = new FileStream(@"G:\str.txt", FileMode.Create, FileAccess.Write);
            ////B:使用文件流
            //byte[] bt = Encoding.UTF8.GetBytes(ms);
            //fs.Write(bt, 0, bt.Length);
            ////清空缓存，关闭流，释放资源（三选一即可）
            //fs.Flush();
            //fs.Close();
            //fs.Dispose();
            //Console.WriteLine("写入OK");
            #endregion

            //读取一个文件，写入另一个文件 (读取大文件，显示拷贝进度)
            #region
            //string Oldpath = @"F:\我的电影\迈克尔杰克逊德国演唱会.rmvb";
            //string Newpath = @"G:\迈克尔杰克逊德国演唱会.rmvb";
            //byte[] b = new byte[5 * 1024 * 1024];
            //using (FileStream r = new FileStream(Oldpath, FileMode.OpenOrCreate, FileAccess.Read))
            //{
            //    using (FileStream w = new FileStream(Newpath, FileMode.Create, FileAccess.Write))
            //    {
            //        while (true)
            //        {
            //            int num = r.Read(b, 0, b.Length);
            //            w.Write(b, 0, num);

            //            double d = Math.Round((w.Position / (double)(r.Length) * 100), 2);
            //            Console.WriteLine(d + "%");

            //            if (num == 0)
            //            {
            //                break;
            //            }
            //        }
            //    }
            //}
            #endregion

            #region  通过自定义的一次性拷贝方法来复制文件
            //string Oldpath = @"G:\编码.txt";
            //string Newpath = @"G:\编码副本.txt";
            //CopyAll(Oldpath, Newpath);
            //Console.WriteLine("拷贝OK");
            #endregion

            //streamReader和streamWriter
            //streamReader是逐行读取文本文件
            #region
            //string filefrom = @"G:\编码.txt";
            //string fileto = @"G:\2\编码.txt";
            //StreamRandWriter(filefrom, fileto);
            //Console.WriteLine("读取OK.....");
            #endregion


            //文件加密和文件解密
            #region 文件加密和解密（将读取到的字节长度运算后写入新文件就是加密，反之为解密）
            //JiaMi(@"E:\iis配置.txt", @"G:\iis配置.txt");
            //Console.WriteLine("加密OK");

            //JieMi(@"G:\iis配置.txt", @"G:\1\iis配置.txt");
            //Console.WriteLine("解密OK");
            #endregion


            //文件压缩
            //GZip 头中的幻数不正确。请确保正在传入 GZip 流。
            #region
            //string source = @"G:\编码.txt";
            //string target = @"G:\编码.zip";
            //YaSuo(source, target);
            //Console.WriteLine("压缩OK");

            //string target1 = @"G:\编码.zip";
            //string source1 = @"G:\1\编码.txt";
            //JieYa(target1, source1);
            //Console.WriteLine("解压OK");
            #endregion


            //给图片添加(字符)水印  
            #region
            //string frompath = @"F:\image\1.jpg";
            //string dt = DateTime.Now.ToString();
            //int fontSize = 50;   //设置字体大小

            //Image img = Image.FromFile(frompath);
            //Graphics gimg = Graphics.FromImage(img);
            //gimg.DrawString(dt, new Font("黑体", fontSize), new SolidBrush(Color.Red), new PointF(img.Width - (fontSize * dt.Length), img.Height - fontSize * 2));
            //img.Save(@"G:\1.jpg");       
            #endregion
            #region
            //ImgSY(@"F:\image\2.jpg", @"G:\2.jpg", DateTime.Now.ToString(), "黑体", Color.White, 50);
            #endregion


            //生成缩略图
            #region
            //string frompath = @"F:\image\1.jpg";
            //Image img = Image.FromFile(frompath);
            //Bitmap bm = new Bitmap(img, 100, 100);
            //Graphics g = Graphics.FromImage(img);
            //g.DrawImage(img, 100, 100, new Rectangle(0, 0, 10, 100), GraphicsUnit.Pixel);

            //bm.Save(@"G:\11.jpg");
            #endregion
            #region
            //ImgSLT(@"F:\image\1.jpg", @"G:\11.jpg", 200, 200, GraphicsUnit.Pixel);
            #endregion
            //MakeThumbnail(@"F:\image\1.jpg", @"G:\11.jpg", 200, 200, "H");


            //-----------------文件操作类---------------

            //1:驱动器类DriveInfo
            DriveInfo[] Drivers = DriveInfo.GetDrives();
            foreach (DriveInfo d in Drivers)
            {
                if (d.IsReady) //光驱可读时（已经准备好了），输出光驱，避免了H盘
                {
                    Console.WriteLine(d + "---" + d.TotalSize / 1024 / 1024 / 1024 + "GB" + "---" + d.DriveType + "---" + d.TotalFreeSpace / 1024 / 1024 / 1024 + "GB");
                }
            }
            DriveInfo driver = new DriveInfo("D");
            string name = driver.Name;
            Console.WriteLine(name);

            //2：文件类FileInfo和File
            string filename = @"G:\全国行政区划数据库sql";
            FileInfo file = new FileInfo(filename);
            Console.WriteLine(file.LastWriteTime);

            //3：文件路径Path
            Path.Combine("", "");


            Console.ReadKey();
        }
        //------------------方法部分------------------
        /// <summary>
        ///  文件加密方法
        /// </summary>
        /// <param name="source">加密前的文件路径</param>
        /// <param name="target">加密后的文件路径</param>
        public static void JiaMi(string source, string target)
        {
            byte[] bt = new byte[1024 * 1024];
            if (source != null && source.Length > 0)
            {
                //创建读取的文件流
                using (FileStream fs = new FileStream(source, FileMode.OpenOrCreate, FileAccess.Read))
                {
                    //创建写入的流
                    using (FileStream fsw = new FileStream(target, FileMode.OpenOrCreate, FileAccess.Write))
                    {
                        while (true)  //因为文件可能比较大，因此应该循环读取(每次1M大小)
                        {
                            int r = fs.Read(bt, 0, bt.Length);//返回本次读取到的实际大小
                            for (int i = 0; i < r; i++)
                            {
                                bt[i] = (byte)(byte.MaxValue - bt[i]);
                            }

                            fsw.Write(bt, 0, r);

                            if (r == 0)
                            {
                                break;
                            }

                        }
                    }
                }
            }
        }
        /// <summary>
        ///文件解密方法 
        /// </summary>
        /// <param name="source">加密后的文件路径</param>
        /// <param name="target">加密前的文件路径</param>
        public static void JieMi(string source, string target)
        {
            byte[] bt = new byte[1024 * 1024];
            if (source != null && source.Length > 0)
            {
                //创建读取的文件流
                using (FileStream fs = new FileStream(source, FileMode.OpenOrCreate, FileAccess.Read))
                {
                    //创建写入的流
                    using (FileStream fsw = new FileStream(target, FileMode.OpenOrCreate, FileAccess.Write))
                    {
                        while (true)  //因为文件可能比较大，因此应该循环读取(每次1M大小)
                        {
                            int r = fs.Read(bt, 0, bt.Length);//返回本次读取到的实际大小
                            for (int i = 0; i < r; i++)
                            {
                                bt[i] = (byte)(byte.MaxValue - bt[i]);
                            }

                            if (r == 0)
                            {
                                break;
                            }

                            fsw.Write(bt, 0, r);

                        }
                    }
                }
            }
        }

        //文件压缩
        public static void YaSuo(string source, string target)
        {
            //创建读，写，压缩文件流
            using (FileStream r = File.OpenRead(source))
            {
                using (FileStream w = File.OpenWrite(target))
                {
                    using (GZipStream zip = new GZipStream(w, CompressionMode.Compress))
                    {
                        byte[] bt = new byte[1024];

                        while (true)
                        {
                            int len = r.Read(bt, 0, bt.Length);
                            if (len == 0)
                            {
                                break;
                            }
                            zip.Write(bt, 0, len);
                        }
                    }
                }
            }
        }
        //文件解压
        public static void JieYa(string target, string source)
        {
            //创建读，写，解压文件流
            using (FileStream r = new FileStream(target, FileMode.OpenOrCreate, FileAccess.Read))
            {
                using (FileStream w = new FileStream(source, FileMode.Open, FileAccess.Write))
                {
                    using (GZipStream zip = new GZipStream(r, CompressionMode.Decompress))
                    {
                        byte[] bt = new byte[1024];

                        while (true)
                        {
                            int len = zip.Read(bt, 0, bt.Length);
                            if (len == 0)
                            {
                                break;
                            }

                            w.Write(bt, 0, len);
                        }

                    }
                }
            }
        }


        //获取文件大小
        public static int GetFilelen(string filepath)
        {
            int db = 0;
            if (filepath != null)
            {
                FileInfo fi = new FileInfo(filepath);
                db = (int)fi.Length;
            }
            return db;
        }

        /// <summary>
        /// 文件拷贝方法1（自定义的方法---一次性读取）
        /// </summary>
        /// <param name="newpath"></param>
        /// <param name="oldpath"></param>
        public static void CopyAll(string filefrom, string fileto)
        {
            if (filefrom != null && filefrom.Length > 0)
            {
                //创建读取的文件流
                using (FileStream fs = new FileStream(filefrom, FileMode.OpenOrCreate, FileAccess.Read))
                {
                    byte[] bt = new byte[fs.Length];
                    //创建写入的流
                    using (FileStream fsw = new FileStream(fileto, FileMode.OpenOrCreate, FileAccess.Write))
                    {
                        int r = fs.Read(bt, 0, bt.Length);//返回本次读取到的实际大小
                        fsw.Write(bt, 0, r);
                    }
                }
            }
        }

        /// <summary>
        /// 文件拷贝方法2（自定义的方法---逐步读取）
        /// </summary>
        /// <param name="newpath"></param>
        /// <param name="oldpath"></param>
        /// streamReader和streamwriter
        public static void Copy(string filefrom, string fileto)
        {
            byte[] bt = new byte[3 * 1024 * 1024];
            if (filefrom != null && filefrom.Length > 0)
            {
                //创建读取的文件流
                using (FileStream fs = new FileStream(filefrom, FileMode.OpenOrCreate, FileAccess.Read))
                {
                    //创建写入的流
                    using (FileStream fsw = new FileStream(fileto, FileMode.OpenOrCreate, FileAccess.Write))
                    {
                        while (true)  //因为文件可能比较大，因此应该循环读取(每次3M大小)
                        {
                            int r = fs.Read(bt, 0, bt.Length);//返回本次读取到的实际大小
                            if (r == 0)
                            {
                                break;
                            }
                            fsw.Write(bt, 0, r);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 使用StreamReader和StreamWriter逐行读取，逐行写入文本文件数据
        /// </summary>
        /// <param name="filefrom"></param>
        /// <param name="fileto"></param>
        public static void StreamRandWriter(string filefrom, string fileto)
        {
            using (StreamReader sr = new StreamReader(filefrom, Encoding.UTF8))
            {
                using (StreamWriter sw = new StreamWriter(fileto, true, Encoding.UTF8))
                {
                    while (true)
                    {
                        string msg = sr.ReadLine();
                        Console.WriteLine(msg);
                        if (msg == null)   //逐行读取，如果没有独到数据就跳出循环
                        {
                            break;
                        }
                        sw.WriteLine(msg);  //逐行写入数据
                    }
                }
            }
        }


        /// <summary>
        /// 文件上传
        /// </summary>
        public static void Upload(string path, string pan)
        {
            string direpan = pan + ":\\" + path.Substring(path.LastIndexOf("\\") + 1);
            if (Directory.Exists(path))
            {
                string[] strfilepath = Directory.GetFiles(path);
                if (strfilepath.Length > 0)
                {
                    if (Directory.Exists(direpan))
                    {
                        foreach (string filepath in strfilepath)
                        {
                            string filename = Path.GetFileName(filepath);
                            if (File.Exists(direpan + "\\" + filename))
                            {
                                continue;
                            }
                            else
                            {
                                File.Copy(filepath, direpan + "\\" + filename);
                            }

                        }
                    }
                    else
                    {
                        Directory.CreateDirectory(direpan);
                        foreach (string filepath in strfilepath)
                        {
                            string filename = Path.GetFileName(filepath);
                            File.Copy(filepath, direpan + "\\" + filename);
                        }
                    }
                }
                else
                {
                    Console.WriteLine(path + "路径下没有文件。。。。");
                }
            }
            else
            {
                Console.WriteLine("不存在" + path + "\r\n");
            }
        }


        public static int num = 1;
        //遍历目录方法
        public static void ScareDir1(string path)
        {
            DirectoryInfo di = new DirectoryInfo(path);
            DirectoryInfo[] dr = di.GetDirectories();
            StringBuilder sb = new StringBuilder(path);

            foreach (DirectoryInfo d in dr)
            {
                if (d.GetDirectories().Length > 0)
                {
                    sb.Append("\\" + d);
                    ScareDir1(sb.ToString());
                }
                else
                {
                    Console.WriteLine(sb.ToString() + "\\" + d);
                }
            }

        }
        //创建目录
        #region
        public static void CreateDir(string path)
        {
            StringBuilder sb = new StringBuilder(path);
            while (num <= 3)
            {
                sb.Append("\\" + num);
                if (Directory.Exists(sb.ToString()))
                {
                    num++;
                    continue;
                }
                else
                {
                    Directory.CreateDirectory(sb.ToString());
                }
                num++;
            }
            Console.WriteLine("OK");
        }
        #endregion
        //删除目录和目录下的文件
        public static void deleteDir(string dir)
        {
            if (Directory.Exists(dir)) //如果存在这个文件夹删除之 
            {
                foreach (string d in Directory.GetFileSystemEntries(dir))
                {
                    if (File.Exists(d))
                    {
                        File.Delete(d); //直接删除其中的文件 
                    }
                    else
                    {
                        deleteDir(d); //递归删除子文件夹 
                    }
                }
                Directory.Delete(dir); //删除已空文件夹 
                Console.WriteLine(dir + " 文件夹删除成功");
            }
            else
            {
                Console.WriteLine(dir + " 该文件夹不存在"); //如果文件夹不存在则提示 
            }
        }



        //图片添加水印
        public static void ImgSY(string fromPath, string toPath, string strSY, string zt, Color c, int fontSize)
        {
            Image img = Image.FromFile(fromPath);
            Graphics gimg = Graphics.FromImage(img);
            gimg.DrawString(strSY, new Font(zt, fontSize), new SolidBrush(c), new PointF(img.Width - (fontSize * strSY.Length), img.Height - fontSize * 2));
            img.Save(toPath);
        }
        //生成缩略图---简单写法
        public static void ImgSLT(string fromPath, string toPath, int PointX, int PointY, GraphicsUnit gu)
        {
            Image img = Image.FromFile(fromPath);
            Bitmap bm = new Bitmap(img, PointX, PointY);
            Graphics g = Graphics.FromImage(img);
            g.DrawImage(img, PointX, PointY, new Rectangle(0, 0, PointX, PointY), gu);

            bm.Save(toPath);
        }
        //生成缩略图---常规写法
        public static void MakeThumbnail(string originalImagePath, string thumbnailPath, int width, int height, string mode)
        {
            Image originalImage = Image.FromFile(originalImagePath);

            int towidth = width;
            int toheight = height;

            int x = 0;
            int y = 0;
            int ow = originalImage.Width;
            int oh = originalImage.Height;

            switch (mode)
            {
                case "HW"://指定高宽缩放（可能变形）                 
                    break;
                case "W"://指定宽，高按比例                     
                    toheight = originalImage.Height * width / originalImage.Width;
                    break;
                case "H"://指定高，宽按比例 
                    towidth = originalImage.Width * height / originalImage.Height;
                    break;
                case "Cut"://指定高宽裁减（不变形）                 
                    if ((double)originalImage.Width / (double)originalImage.Height > (double)towidth / (double)toheight)
                    {
                        oh = originalImage.Height;
                        ow = originalImage.Height * towidth / toheight;
                        y = 0;
                        x = (originalImage.Width - ow) / 2;
                    }
                    else
                    {
                        ow = originalImage.Width;
                        oh = originalImage.Width * height / towidth;
                        x = 0;
                        y = (originalImage.Height - oh) / 2;
                    }
                    break;
                default:
                    break;
            }

            //新建一个bmp图片 
            Image bitmap = new System.Drawing.Bitmap(towidth, toheight);
            //新建一个画板 
            Graphics g = System.Drawing.Graphics.FromImage(bitmap);
            //设置高质量插值法 
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            //设置高质量,低速度呈现平滑程度 
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            //清空画布并以透明背景色填充 
            g.Clear(Color.Transparent);
            //在指定位置并且按指定大小绘制原图片的指定部分 
            g.DrawImage(originalImage, new Rectangle(0, 0, towidth, toheight),
                new Rectangle(x, y, ow, oh),
                GraphicsUnit.Pixel);

            try
            {
                //以jpg格式保存缩略图 
                bitmap.Save(thumbnailPath, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            catch (System.Exception e)
            {
                throw e;
            }
            finally
            {
                originalImage.Dispose();
                bitmap.Dispose();
                g.Dispose();
            }
        }

    }
}
