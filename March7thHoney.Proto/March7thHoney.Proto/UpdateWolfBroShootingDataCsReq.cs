using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class UpdateWolfBroShootingDataCsReq : IMessage<UpdateWolfBroShootingDataCsReq>, IMessage, IEquatable<UpdateWolfBroShootingDataCsReq>, IDeepCloneable<UpdateWolfBroShootingDataCsReq>, IBufferMessage
{
	private static readonly MessageParser<UpdateWolfBroShootingDataCsReq> _parser = new MessageParser<UpdateWolfBroShootingDataCsReq>(() => new UpdateWolfBroShootingDataCsReq());

	private UnknownFieldSet _unknownFields;

	public const int DIFLKHMKHBGFieldNumber = 3;

	private DEOMNEOMPFE dIFLKHMKHBG_;

	public const int ECEACBAGAKDFieldNumber = 7;

	private uint eCEACBAGAKD_;

	public const int GroupIdFieldNumber = 10;

	private uint groupId_;

	public const int UuidFieldNumber = 13;

	private ulong uuid_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<UpdateWolfBroShootingDataCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => UpdateWolfBroShootingDataCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DEOMNEOMPFE DIFLKHMKHBG
	{
		get
		{
			return dIFLKHMKHBG_;
		}
		set
		{
			dIFLKHMKHBG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ECEACBAGAKD
	{
		get
		{
			return eCEACBAGAKD_;
		}
		set
		{
			eCEACBAGAKD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GroupId
	{
		get
		{
			return groupId_;
		}
		set
		{
			groupId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong Uuid
	{
		get
		{
			return uuid_;
		}
		set
		{
			uuid_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UpdateWolfBroShootingDataCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UpdateWolfBroShootingDataCsReq(UpdateWolfBroShootingDataCsReq other)
		: this()
	{
		dIFLKHMKHBG_ = ((other.dIFLKHMKHBG_ != null) ? other.dIFLKHMKHBG_.Clone() : null);
		eCEACBAGAKD_ = other.eCEACBAGAKD_;
		groupId_ = other.groupId_;
		uuid_ = other.uuid_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UpdateWolfBroShootingDataCsReq Clone()
	{
		return new UpdateWolfBroShootingDataCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as UpdateWolfBroShootingDataCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(UpdateWolfBroShootingDataCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(DIFLKHMKHBG, other.DIFLKHMKHBG))
		{
			return false;
		}
		if (ECEACBAGAKD != other.ECEACBAGAKD)
		{
			return false;
		}
		if (GroupId != other.GroupId)
		{
			return false;
		}
		if (Uuid != other.Uuid)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		int num = 1;
		if (dIFLKHMKHBG_ != null)
		{
			num ^= DIFLKHMKHBG.GetHashCode();
		}
		if (ECEACBAGAKD != 0)
		{
			num ^= ECEACBAGAKD.GetHashCode();
		}
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		if (Uuid != 0L)
		{
			num ^= Uuid.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return JsonFormatter.ToDiagnosticString(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
		output.WriteRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (dIFLKHMKHBG_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(DIFLKHMKHBG);
		}
		if (ECEACBAGAKD != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(ECEACBAGAKD);
		}
		if (GroupId != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(GroupId);
		}
		if (Uuid != 0L)
		{
			output.WriteRawTag(104);
			output.WriteUInt64(Uuid);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(ref output);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		int num = 0;
		if (dIFLKHMKHBG_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DIFLKHMKHBG);
		}
		if (ECEACBAGAKD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ECEACBAGAKD);
		}
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GroupId);
		}
		if (Uuid != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(Uuid);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(UpdateWolfBroShootingDataCsReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.dIFLKHMKHBG_ != null)
		{
			if (dIFLKHMKHBG_ == null)
			{
				DIFLKHMKHBG = new DEOMNEOMPFE();
			}
			DIFLKHMKHBG.MergeFrom(other.DIFLKHMKHBG);
		}
		if (other.ECEACBAGAKD != 0)
		{
			ECEACBAGAKD = other.ECEACBAGAKD;
		}
		if (other.GroupId != 0)
		{
			GroupId = other.GroupId;
		}
		if (other.Uuid != 0L)
		{
			Uuid = other.Uuid;
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
		input.ReadRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalMergeFrom(ref ParseContext input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0 && (num & 7) != 4)
		{
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 26u:
				if (dIFLKHMKHBG_ == null)
				{
					DIFLKHMKHBG = new DEOMNEOMPFE();
				}
				input.ReadMessage(DIFLKHMKHBG);
				break;
			case 56u:
				ECEACBAGAKD = input.ReadUInt32();
				break;
			case 80u:
				GroupId = input.ReadUInt32();
				break;
			case 104u:
				Uuid = input.ReadUInt64();
				break;
			}
		}
	}
}
