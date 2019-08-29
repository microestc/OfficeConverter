# OfficeConverter

本程序使用命令 libreoffice 转换office文件

quick start
 
 var service = new OfficeService();
 service.Convert(new TaskSetup("1000", @"C:\app\1.doc", @"C:\app"));

 or at aspnetcore configureServices 

 services.AddSinglton<IOfficeService,OfficeService>();


