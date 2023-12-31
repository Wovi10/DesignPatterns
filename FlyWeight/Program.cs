﻿// See https://aka.ms/new-console-template for more information

using FlyWeight;

Console.Title = "FlyWeight Adapter";

const string aBunchOfCharacters = "abba";

var characterFactory = new CharacterFactory();

var characterObject = characterFactory.GetCharacter(aBunchOfCharacters[0]);
characterObject?.Draw("Arial", 12);

characterObject = characterFactory.GetCharacter(aBunchOfCharacters[1]);
characterObject?.Draw("Trebuchet MS", 14);

characterObject = characterFactory.GetCharacter(aBunchOfCharacters[2]);
characterObject?.Draw("Times New Roman", 16);

characterObject = characterFactory.GetCharacter(aBunchOfCharacters[3]);
characterObject?.Draw("Comic Sans", 18);

Console.WriteLine();

if (characterObject != null)
{
    var paragraph = characterFactory.CreateParagraph(new List<ICharacter>() {characterObject}, 1);
    paragraph.Draw("Lucinda", 12);
}


Console.ReadKey();