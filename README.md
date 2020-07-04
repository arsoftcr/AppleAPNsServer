# AppleAPNsServer ![NuGet Version](http://img.shields.io/static/v1?label=Arsoftcr&message=La%20mejor%20tecnología&color=blue)

Configure su propio servidor de APNS para enviar push notifications a aplicaciones cliente de IOS. 

Sirve con cualquier aplicación  cliente IOS  como por ejemplo : IOS nativo (xcode), xamarin forms, react native,flutter entre otros.

Para usarlo debe contar el certificado p12  push notifications  de apple (apple developer) y se debe instalar en el servidor ,se debe instalar el paquete nuget https://www.nuget.org/packages/AppleApnsServer ![NuGet Version](http://img.shields.io/static/v1?label=Nuget&message=1.0.0&color=blue)



## Modo de Uso:


         X509Certificate2 certificate = new X509Certificate2(**Ruta del certificado .p12**
                 ,**Clave del certificado**);



            ApnsHttp2Configuration apnsHttp2Configuration =
                 new ApnsHttp2Configuration(
                     ApnsHttp2Configuration.ApnsServerEnvironment.Sandbox,
                     certificate);

            ApnsHttp2Connection connection = new ApnsHttp2Connection(apnsHttp2Configuration);

            ApnsHttp2Notification apnsHttp2Notification = new ApnsHttp2Notification
            {

                DeviceToken = **token del dispositivo**,
                Expiration = DateTime.Now.AddHours(1),
                Payload = Newtonsoft.Json.Linq.JObject.Parse(**Payload json**),
                Priority = ApnsPriority.High,
               
                Topic = "**bundle id**",
                Uuid = Guid.NewGuid().ToString()
            };

            await connection.Send(apnsHttp2Notification);


  
        
          
          
          
     
          
       
