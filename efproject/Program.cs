// See https://aka.ms/new-console-template for more information
using efproject;

//TableService.AddActor("Dicabrio", "Titanik");
//TableService.AddActor("Silvester", "Rokki");
//TableService.AddActor("Shoxruhxon", "Don");
//TableService.Update("Silvester", "Escape plan");
//TableService.RemoveActor("Dicabrio");
var actor = TableService.GetActorByName("Silvester");
Console.WriteLine();