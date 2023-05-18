namespace Dji.Cloud.Domain.Websocket.Config;

public class AuthPrincipalHandler
{
    //@Override
    //protected boolean isValidOrigin(ServerHttpRequest request)
    //{

    //    if (request instanceof ServletServerHttpRequest) {
    //        HttpServletRequest servletRequest = ((ServletServerHttpRequest)request).getServletRequest();
    //        String token = servletRequest.getParameter(AuthInterceptor.PARAM_TOKEN);

    //        if (!StringUtils.hasText(token))
    //        {
    //            return false;
    //        }
    //        log.debug("token:" + token);
    //        Optional<CustomClaim> customClaim = JwtUtil.parseToken(token);
    //        if (customClaim.isEmpty())
    //        {
    //            return false;
    //        }

    //        servletRequest.setAttribute(AuthInterceptor.TOKEN_CLAIM, customClaim.get());
    //        return true;
    //    }
    //    return false;

    //}

    ///**
    // * The principal's name: {workspaceId}/{userType}/{userId}
    // * @param request
    // * @param wsHandler
    // * @param attributes
    // * @return
    // */
    //@Override
    //protected Principal determineUser(ServerHttpRequest request, WebSocketHandler wsHandler, Map<String, Object> attributes)
    //{
    //    if (request instanceof ServletServerHttpRequest) {

    //        // get the custom claim
    //        CustomClaim claim = (CustomClaim)((ServletServerHttpRequest)request).getServletRequest()
    //                .getAttribute(AuthInterceptor.TOKEN_CLAIM);

    //        return ()->claim.getWorkspaceId() + "/" + claim.getUserType() + "/" + claim.getId();
    //    }
    //    return ()-> null;
    //}
}
