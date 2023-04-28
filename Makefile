test:
	@echo "$(OK_COLOR)==> Running tests using docker-compose deps$(NO_COLOR)"
	@docker-compose up -d
	cd "./2-Test/Database/" && \
	dotnet test -e PG_URI="postgres://test:test@`docker-compose port postgres 5432`/test?sslmode=disable"