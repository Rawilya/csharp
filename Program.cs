using System;
using System.IO;
using System.Xml.Serialization;

using System.Collections;

namespace project 
{
    
  public class Program 
   {
     
     public static void Main()
    {  
      
      
      System.Console.Write("ВВедите имя:");
      string ? name = Console.ReadLine()??"";
      System.Console.Write("ВВедите логин:");
      string ? login = Console.ReadLine()?? "";
      System.Console.Write("ВВедите возраст:");
      int age = Convert.ToInt32(Console.ReadLine());
      System.Console.Write("Введите хобби: ");
      string hobby = Console.ReadLine()??"";
      string[] hobbiArr = hobby.Split(",");
      List<string> hobbies = hobbiArr.ToList();

      

      XmlSerializer xml = new XmlSerializer(typeof(Users));
      using(FileStream file= new FileStream("object.xml", FileMode.OpenOrCreate)){
        Users Yuliya = new Users(name, login,age,hobbies);
        xml.Serialize(file,Yuliya);
        System.Console.WriteLine("Сериализация выполнена успешно");
      }
      
    
      using(FileStream file= new FileStream("object.xml", FileMode.OpenOrCreate)){
       
        xml.Deserialize(file);
        System.Console.WriteLine("Дериализация выполнена успешно");
        
      }
      Users user = new Users();
        user.GetInfo();
      
       
     
      
      
     
     
      
      
      

       
    }
  }      
       
}  
       


            
  
  



       

     

     
       
      
     
         
       

    
   

