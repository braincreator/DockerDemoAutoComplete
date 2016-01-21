FROM microsoft/aspnet:latest

# Install NPM
#RUN apt-get update && apt-get install -y curl
#RUN curl -sL https://deb.nodesource.com/setup | bash -
#RUN apt-get install -y nodejs

# Install Gulp
#RUN npm install -g gulp
#RUN npm install -g bower

COPY . /app/  
WORKDIR /app  
#install nuget packages
RUN ["dnu", "restore"]
#WORKDIR ./src/AutoComplete

#RUN npm -g install npm@latest-2
#RUN ["gulp", "clean"]
#RUN ["gulp", "min"]
#RUN ["bower", "install", "--allow-root"]

EXPOSE 5005
ENTRYPOINT ["dnx", "web", "--server.urls", "http://0.0.0.0:5005"]

