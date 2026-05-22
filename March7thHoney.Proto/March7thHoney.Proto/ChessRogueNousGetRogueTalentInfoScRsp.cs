using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChessRogueNousGetRogueTalentInfoScRsp : IMessage<ChessRogueNousGetRogueTalentInfoScRsp>, IMessage, IEquatable<ChessRogueNousGetRogueTalentInfoScRsp>, IDeepCloneable<ChessRogueNousGetRogueTalentInfoScRsp>, IBufferMessage
{
	private static readonly MessageParser<ChessRogueNousGetRogueTalentInfoScRsp> _parser = new MessageParser<ChessRogueNousGetRogueTalentInfoScRsp>(() => new ChessRogueNousGetRogueTalentInfoScRsp());

	private UnknownFieldSet _unknownFields;

	public const int MPGDJOGHKBHFieldNumber = 1;

	private uint mPGDJOGHKBH_;

	public const int RetcodeFieldNumber = 2;

	private uint retcode_;

	public const int TalentInfoFieldNumber = 9;

	private MCACDFHCPIE talentInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChessRogueNousGetRogueTalentInfoScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChessRogueNousGetRogueTalentInfoScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MPGDJOGHKBH
	{
		get
		{
			return mPGDJOGHKBH_;
		}
		set
		{
			mPGDJOGHKBH_ = value;
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
	public ChessRogueNousGetRogueTalentInfoScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueNousGetRogueTalentInfoScRsp(ChessRogueNousGetRogueTalentInfoScRsp other)
		: this()
	{
		mPGDJOGHKBH_ = other.mPGDJOGHKBH_;
		retcode_ = other.retcode_;
		talentInfo_ = ((other.talentInfo_ != null) ? other.talentInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueNousGetRogueTalentInfoScRsp Clone()
	{
		return new ChessRogueNousGetRogueTalentInfoScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChessRogueNousGetRogueTalentInfoScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChessRogueNousGetRogueTalentInfoScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MPGDJOGHKBH != other.MPGDJOGHKBH)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!object.Equals(TalentInfo, other.TalentInfo))
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
		if (MPGDJOGHKBH != 0)
		{
			num ^= MPGDJOGHKBH.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (talentInfo_ != null)
		{
			num ^= TalentInfo.GetHashCode();
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
		if (MPGDJOGHKBH != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(MPGDJOGHKBH);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(Retcode);
		}
		if (talentInfo_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(TalentInfo);
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
		if (MPGDJOGHKBH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MPGDJOGHKBH);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (talentInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(TalentInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChessRogueNousGetRogueTalentInfoScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.MPGDJOGHKBH != 0)
		{
			MPGDJOGHKBH = other.MPGDJOGHKBH;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.talentInfo_ != null)
		{
			if (talentInfo_ == null)
			{
				TalentInfo = new MCACDFHCPIE();
			}
			TalentInfo.MergeFrom(other.TalentInfo);
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
				MPGDJOGHKBH = input.ReadUInt32();
				break;
			case 16u:
				Retcode = input.ReadUInt32();
				break;
			case 74u:
				if (talentInfo_ == null)
				{
					TalentInfo = new MCACDFHCPIE();
				}
				input.ReadMessage(TalentInfo);
				break;
			}
		}
	}
}
