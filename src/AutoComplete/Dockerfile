FROM microsoft/aspnet

# Set the ASP.NET 5 environment variable to indicate our current environment
ENV ASPNET_ENV Production
 
# Copy over our web project
COPY . /project
 
# Set the working directory to the copied project
WORKDIR /project
 
# As a part of the build process, restore all the dependencies into the container
RUN ["dnu", "restore"]
 
# When we run the container, it will launch the web server for us
# NOTE: We have to specify --server.urls so that it uses 0.0.0.0 instead of the default localhost,
# otherwise we will not be able to view the website outside of the container
ENTRYPOINT ["dnx", "-p", "project.json", "web"]

