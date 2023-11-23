PROJECT_NAME=${1:-$(cat /dev/urandom | tr -dc 'a-z0-9' | fold -w 8 | head -n 1)}
LOCATION=${2:-westus}

az group create --name "rg-${PROJECT_NAME}" --location "${LOCATION}"

az appconfig create --resource-group "rg-${PROJECT_NAME}" --name "${PROJECT_NAME}-config" --location "${LOCATION}" --sku "free"
