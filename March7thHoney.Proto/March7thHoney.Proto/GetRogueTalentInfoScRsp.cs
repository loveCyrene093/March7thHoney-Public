using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetRogueTalentInfoScRsp : IMessage<GetRogueTalentInfoScRsp>, IMessage, IEquatable<GetRogueTalentInfoScRsp>, IDeepCloneable<GetRogueTalentInfoScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetRogueTalentInfoScRsp> _parser = new MessageParser<GetRogueTalentInfoScRsp>(() => new GetRogueTalentInfoScRsp());

	private UnknownFieldSet _unknownFields;

	public const int TalentInfoFieldNumber = 7;

	private MCACDFHCPIE talentInfo_;

	public const int RetcodeFieldNumber = 11;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetRogueTalentInfoScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetRogueTalentInfoScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MCACDFHCPIE TalentInfo
	{
		get
		{
			return talentInfo_;
		}
		set
		{
			talentInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetRogueTalentInfoScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetRogueTalentInfoScRsp(GetRogueTalentInfoScRsp other)
		: this()
	{
		talentInfo_ = ((other.talentInfo_ != null) ? other.talentInfo_.Clone() : null);
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetRogueTalentInfoScRsp Clone()
	{
		return new GetRogueTalentInfoScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetRogueTalentInfoScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetRogueTalentInfoScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(TalentInfo, other.TalentInfo))
		{
			return false;
		}
		if (Retcode != other.Retcode)
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
		if (talentInfo_ != null)
		{
			num ^= TalentInfo.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
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
		if (talentInfo_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(TalentInfo);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(Retcode);
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
		if (talentInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(TalentInfo);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetRogueTalentInfoScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.talentInfo_ != null)
		{
			if (talentInfo_ == null)
			{
				TalentInfo = new MCACDFHCPIE();
			}
			TalentInfo.MergeFrom(other.TalentInfo);
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
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
			case 58u:
				if (talentInfo_ == null)
				{
					TalentInfo = new MCACDFHCPIE();
				}
				input.ReadMessage(TalentInfo);
				break;
			case 88u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
