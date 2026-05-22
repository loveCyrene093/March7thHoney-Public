using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetTalkEventRewardCsReq : IMessage<GetTalkEventRewardCsReq>, IMessage, IEquatable<GetTalkEventRewardCsReq>, IDeepCloneable<GetTalkEventRewardCsReq>, IBufferMessage
{
	private static readonly MessageParser<GetTalkEventRewardCsReq> _parser = new MessageParser<GetTalkEventRewardCsReq>(() => new GetTalkEventRewardCsReq());

	private UnknownFieldSet _unknownFields;

	public const int JHOAMILHAICFieldNumber = 1;

	private uint jHOAMILHAIC_;

	public const int ILKEFLDBMLFFieldNumber = 9;

	private Vector iLKEFLDBMLF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetTalkEventRewardCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetTalkEventRewardCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JHOAMILHAIC
	{
		get
		{
			return jHOAMILHAIC_;
		}
		set
		{
			jHOAMILHAIC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Vector ILKEFLDBMLF
	{
		get
		{
			return iLKEFLDBMLF_;
		}
		set
		{
			iLKEFLDBMLF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetTalkEventRewardCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetTalkEventRewardCsReq(GetTalkEventRewardCsReq other)
		: this()
	{
		jHOAMILHAIC_ = other.jHOAMILHAIC_;
		iLKEFLDBMLF_ = ((other.iLKEFLDBMLF_ != null) ? other.iLKEFLDBMLF_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetTalkEventRewardCsReq Clone()
	{
		return new GetTalkEventRewardCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetTalkEventRewardCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetTalkEventRewardCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (JHOAMILHAIC != other.JHOAMILHAIC)
		{
			return false;
		}
		if (!object.Equals(ILKEFLDBMLF, other.ILKEFLDBMLF))
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
		if (JHOAMILHAIC != 0)
		{
			num ^= JHOAMILHAIC.GetHashCode();
		}
		if (iLKEFLDBMLF_ != null)
		{
			num ^= ILKEFLDBMLF.GetHashCode();
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
		if (JHOAMILHAIC != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(JHOAMILHAIC);
		}
		if (iLKEFLDBMLF_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(ILKEFLDBMLF);
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
		if (JHOAMILHAIC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JHOAMILHAIC);
		}
		if (iLKEFLDBMLF_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ILKEFLDBMLF);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetTalkEventRewardCsReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.JHOAMILHAIC != 0)
		{
			JHOAMILHAIC = other.JHOAMILHAIC;
		}
		if (other.iLKEFLDBMLF_ != null)
		{
			if (iLKEFLDBMLF_ == null)
			{
				ILKEFLDBMLF = new Vector();
			}
			ILKEFLDBMLF.MergeFrom(other.ILKEFLDBMLF);
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
			case 8u:
				JHOAMILHAIC = input.ReadUInt32();
				break;
			case 74u:
				if (iLKEFLDBMLF_ == null)
				{
					ILKEFLDBMLF = new Vector();
				}
				input.ReadMessage(ILKEFLDBMLF);
				break;
			}
		}
	}
}
