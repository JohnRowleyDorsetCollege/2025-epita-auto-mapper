// See https://aka.ms/new-console-template for more information
using _2025_epita_auto_mapper.Models;
using _2025_epita_auto_mapper.Models.Mapper;
using AutoMapper;
using Bogus;
using System;

Console.WriteLine("Hello, World!");

var config = new MapperConfiguration(cfg =>
{
    cfg.AddProfile<UserProfile>();
});

var mapper = new Mapper(config);
var faker = new Faker("en");
var user = new User
{
    Id = Faker.GlobalUniqueIndex,
    FullName = faker.Internet.UserName(),
    Email = faker.Internet.Email()

};

UserDto userDto = mapper.Map<UserDto>(user);

Console.WriteLine($"FullName: {userDto.FullName}, Email:  {userDto.Email}");