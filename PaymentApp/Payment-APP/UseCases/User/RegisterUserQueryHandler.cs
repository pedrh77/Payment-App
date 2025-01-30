using Payment_APP.DTOs.User;
using Payment_APP.Queries;

namespace Payment_APP.UseCases.User;

public class RegisterUserQueryHandler : IQueryHandler<RegisterUserQuery, RegisterUserDto>
{
    public async Task<RegisterUserDto> Handle(RegisterUserQuery request, CancellationToken cancellationToken)
    {
        //TO - DO

        /*
        
        Before make all the steps.
            confirm email off user - validade if already exists
                if doesn't exists try send SMTP to make the confirmation.

            encrypt the Password.
                Save the password encripted
         */

        //Save data
        //create wallet - empty value (0.00)

        throw new Exception();
    }
}
