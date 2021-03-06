﻿using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.MPQ.Apis
{
    public class GetGroupsApiMahuaCommandHandler
        : MpqApiMahuaCommandHandlerBase<GetGroupsApiMahuaCommand, GetGroupsApiMahuaCommandResult>
    {
        public GetGroupsApiMahuaCommandHandler(
            IMpqApi mpqApi,
            IRobotSessionContext robotSessionContext,
            IEventFunOutput eventFunOutput)
            : base(mpqApi, robotSessionContext, eventFunOutput)
        {
        }

        public override GetGroupsApiMahuaCommandResult Handle(GetGroupsApiMahuaCommand message)
        {
            var groupsString = MpqApi.Api_GetGroupListB(CurrentQq);
            var re = new GetGroupsApiMahuaCommandResult
            {
                GroupsString = groupsString
            };
            return re;
        }
    }
}
