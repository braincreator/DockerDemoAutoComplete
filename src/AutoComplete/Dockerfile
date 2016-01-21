FROM microsoft/aspnet

RUN apt-get update && apt-get install -y curl
RUN curl -sL https://deb.nodesource.com/setup | bash -
RUN apt-get install -y nodejs

EXPOSE 5005

COPY project.json /app/  
WORKDIR /app  
#install nuget packages
RUN ["dnu", "restore"]
#install bower and gulp
RUN npm install -g bower
RUN npm install -g gulp

COPY . /app  

CMD ["cd", "/app/"]
CMD ["npm", "install"]
CMD ["bower", "install"]

ENTRYPOINT ["dnx", "-p", "project.json", "web"]

