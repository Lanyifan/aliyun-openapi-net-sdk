/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.cloudesl.Model.V20200201;

namespace Aliyun.Acs.cloudesl.Transform.V20200201
{
    public class DeleteApDeviceResponseUnmarshaller
    {
        public static DeleteApDeviceResponse Unmarshall(UnmarshallerContext context)
        {
			DeleteApDeviceResponse deleteApDeviceResponse = new DeleteApDeviceResponse();

			deleteApDeviceResponse.HttpResponse = context.HttpResponse;
			deleteApDeviceResponse.ErrorMessage = context.StringValue("DeleteApDevice.ErrorMessage");
			deleteApDeviceResponse.ErrorCode = context.StringValue("DeleteApDevice.ErrorCode");
			deleteApDeviceResponse.Message = context.StringValue("DeleteApDevice.Message");
			deleteApDeviceResponse.DynamicCode = context.StringValue("DeleteApDevice.DynamicCode");
			deleteApDeviceResponse.Code = context.StringValue("DeleteApDevice.Code");
			deleteApDeviceResponse.DynamicMessage = context.StringValue("DeleteApDevice.DynamicMessage");
			deleteApDeviceResponse.RequestId = context.StringValue("DeleteApDevice.RequestId");
			deleteApDeviceResponse.Success = context.BooleanValue("DeleteApDevice.Success");
        
			return deleteApDeviceResponse;
        }
    }
}
