FROM microsoft/aspnet

EXPOSE 5005
ENTRYPOINT ["dnx", "-p", "project.json", "web"]

COPY project.json /app/  
WORKDIR /app  
RUN ["dnu", "restore"]  
COPY . /app  
