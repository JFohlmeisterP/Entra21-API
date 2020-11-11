using System.Collections.Generic;

namespace Domain.Teams
{
    public class TeamsService
    {
        public CreatedTeamDTO Create(string name)
        {
            var team = new Team(name);
            var teamValidation = team.Validate();

            if (teamValidation.isValid)
            {
                TeamsRepository.Add(team);
                return new CreatedTeamDTO(team.Id);
            }

            return new CreatedTeamDTO(teamValidation.errors);
        }
    }
}