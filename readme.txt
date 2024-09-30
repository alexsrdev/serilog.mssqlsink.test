# Use Visual Studio (not Visual Studio Code) to replicate issue

# Dotnet CLI tool may require to install the following tool: 
dotnet tool install --global dotnet-ef

# Create Docker DB if needed
docker build -t db .
docker run --name mssql -d -p 1433:1433 db