FROM ubuntu:jammy

EXPOSE 5000

ENV ASPNETCORE_ENVIRONMENT="Production"
ENV ASPNETCORE_URLS="http://*:5000"

RUN \
  apt-get -y update && \
  apt-get -y install \
  apt-utils \
  wget \
  apt-transport-https \
  unzip \
  acl \
  libssl1.0

RUN \
  apt-get -y install aspnetcore-runtime-6.0

RUN \
  mkdir -p /var/www/nexus && \
  mkdir /config && \
  wget -q https://github.com/immense/Nexus/releases/latest/download/Nexus_Server_Linux-x64.zip && \
  unzip -o Nexus_Server_Linux-x64.zip -d /var/www/nexus && \
  rm Nexus_Server_Linux-x64.zip

RUN \
  mkdir -p /nexus-data && \
  sed -i 's/DataSource=Nexus.db/DataSource=\/nexus-data\/Nexus.db/' /var/www/nexus/appsettings.json

VOLUME "/nexus-data"

WORKDIR /var/www/nexus

COPY DockerMain.sh /

RUN chmod 755 /DockerMain.sh

ENTRYPOINT ["/DockerMain.sh"]