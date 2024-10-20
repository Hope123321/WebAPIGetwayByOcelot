# WebAPIGetway

In a microservice architecture, an API Gateway serves as a single entry point for all client requests. It acts as a reverse proxy, routing client requests to the appropriate microservice and handling various cross-cutting concerns such as authentication, logging, and rate limiting. This approach simplifies the client interaction by providing a unified interface to multiple services, making the architecture more manageable and scalable.

## Step-by-step Guide

1. Install Ocelot NuGet package  
![image](https://github.com/user-attachments/assets/c8cdca53-0d67-4c68-814f-851d52ce8520)

2.Create an ocelot.json configuration file

    {
    "GlobalConfiguration": {
      "BaseUrl": "https://localhost:7025"
    },
    "Routes": [
      //Basket
      {
        "UpstreamPathTemplate": "/Gateway/API/Basket",
        "UpstreamHttpMethod": [ "Get" ],
        "DownstreamPathTemplate": "/Test",
        "DownstreamScheme": "https",
        "DownstreamHostAndPorts": [
          {
            "Host": "localhost",
            "Port": 7126
          }
        ]
      },
      //Identify
      {
        "UpstreamPathTemplate": "/Gateway/API/Identify",
        "UpstreamHttpMethod": [ "Get" ],
        "DownstreamPathTemplate": "/Test",
        "DownstreamScheme": "https",
        "DownstreamHostAndPorts": [
          {
            "Host": "localhost",
            "Port": 7267
          }
        ]
      }
    ]
    }

3.Create Downstream Services

create WebAPI by following  
![image](https://github.com/user-attachments/assets/8ab5e4da-9c03-460a-90de-02dae0390a45)

update the controller by following (sample by BasketAPI)  
![image](https://github.com/user-attachments/assets/e383b2d7-fe35-453b-85d8-fed486dee8db)


4.Run the Application And Test the Gateway  

![image](https://github.com/user-attachments/assets/964929e6-378b-49dc-a836-1a91f8b3ad66)

Is Successfully!
