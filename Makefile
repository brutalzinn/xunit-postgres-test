test:
	@echo "$(OK_COLOR)==> Running tests using docker-compose deps$(NO_COLOR)"
	@docker-compose up -d
	@sleep 3 && \
		PG_URI="postgres://test:test@`docker-compose port postgres 5432`/test?sslmode=disable" \
		dotnet test 2-Test\Database