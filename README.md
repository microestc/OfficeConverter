# OfficeConverter

������ʹ������ libreoffice ת��office�ļ�

quick start
 
 var service = new OfficeService();
 service.Convert(new TaskSetup("1000", @"C:\app\1.doc", @"C:\app"));

 or at aspnetcore configureServices 

 services.AddSinglton<IOfficeService,OfficeService>();


