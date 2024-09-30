FROM mcr.microsoft.com/mssql/server

# Set environment variables for SQL Server
ENV ACCEPT_EULA=Y
ENV MSSQL_SA_PASSWORD=Password1234

# Expose the SQL Server port
EXPOSE 1433