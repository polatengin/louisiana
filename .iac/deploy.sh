PROJECT_NAME=${1:-$(cat /dev/urandom | tr -dc 'a-z0-9' | fold -w 8 | head -n 1)}
LOCATION=${2:-westus}
