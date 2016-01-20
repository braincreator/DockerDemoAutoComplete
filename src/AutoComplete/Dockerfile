FROM microsoft/aspnet

#install npm in docker image
RUN apt-get update && apt-get install -y curl
RUN curl -sL https://deb.nodesource.com/setup | bash -
RUN apt-get install -y nodejs

#install bower and grunt
RUN npm install -g bower
RUN npm install -g gulp -y

EXPOSE 5005

COPY project.json /app/  
WORKDIR /app  
RUN ["dnu", "restore"]
RUN ["gulp", "clean"]
RUN ["gulp", "min"]
COPY . /app  

ENTRYPOINT ["dnx", "-p", "project.json", "web"]
