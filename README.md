# MarsHealthInsights
MarsHealthInsights - A tool to help Mars leaders understand health data from the CDC, focusing on things like how sickness spreads and who's getting vaccinated.

## Here's my plan

## 1 
Data Ingestion Pipeline: I will create a script to fetch data from the provided CDC dataset (https://data.cdc.gov/api/views/qz99-wyhv/rows.json?accessType=DOWNLOAD). This script will validate and transform the data as needed and then store it in database (SQL Server) via Entity Framework code first.

## 2
API Development: Using the stored data, I'll build an API that frontend can interact with to visualize the data. This API will allow filtering by National or Jurisdictional, as well as by vaccination status, intent, and demographics.

## 3
Authentication: If time permits, I will add authentication to the API to ensure secure access.
