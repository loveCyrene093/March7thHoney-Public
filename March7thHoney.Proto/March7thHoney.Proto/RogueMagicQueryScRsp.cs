using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RogueMagicQueryScRsp : IMessage<RogueMagicQueryScRsp>, IMessage, IEquatable<RogueMagicQueryScRsp>, IDeepCloneable<RogueMagicQueryScRsp>, IBufferMessage
{
	private static readonly MessageParser<RogueMagicQueryScRsp> _parser = new MessageParser<RogueMagicQueryScRsp>(() => new RogueMagicQueryScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 4;

	private uint retcode_;

	public const int HHDLEADBJGNFieldNumber = 9;

	private AHOLOHCLLKD hHDLEADBJGN_;

	public const int RogueGetInfoFieldNumber = 15;

	private AHNGIOFDJNL rogueGetInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RogueMagicQueryScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RogueMagicQueryScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public AHOLOHCLLKD HHDLEADBJGN
	{
		get
		{
			return hHDLEADBJGN_;
		}
		set
		{
			hHDLEADBJGN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AHNGIOFDJNL RogueGetInfo
	{
		get
		{
			return rogueGetInfo_;
		}
		set
		{
			rogueGetInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueMagicQueryScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueMagicQueryScRsp(RogueMagicQueryScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		hHDLEADBJGN_ = ((other.hHDLEADBJGN_ != null) ? other.hHDLEADBJGN_.Clone() : null);
		rogueGetInfo_ = ((other.rogueGetInfo_ != null) ? other.rogueGetInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueMagicQueryScRsp Clone()
	{
		return new RogueMagicQueryScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RogueMagicQueryScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RogueMagicQueryScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!object.Equals(HHDLEADBJGN, other.HHDLEADBJGN))
		{
			return false;
		}
		if (!object.Equals(RogueGetInfo, other.RogueGetInfo))
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
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (hHDLEADBJGN_ != null)
		{
			num ^= HHDLEADBJGN.GetHashCode();
		}
		if (rogueGetInfo_ != null)
		{
			num ^= RogueGetInfo.GetHashCode();
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
		if (Retcode != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(Retcode);
		}
		if (hHDLEADBJGN_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(HHDLEADBJGN);
		}
		if (rogueGetInfo_ != null)
		{
			output.WriteRawTag(122);
			output.WriteMessage(RogueGetInfo);
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
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (hHDLEADBJGN_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HHDLEADBJGN);
		}
		if (rogueGetInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(RogueGetInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RogueMagicQueryScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.hHDLEADBJGN_ != null)
		{
			if (hHDLEADBJGN_ == null)
			{
				HHDLEADBJGN = new AHOLOHCLLKD();
			}
			HHDLEADBJGN.MergeFrom(other.HHDLEADBJGN);
		}
		if (other.rogueGetInfo_ != null)
		{
			if (rogueGetInfo_ == null)
			{
				RogueGetInfo = new AHNGIOFDJNL();
			}
			RogueGetInfo.MergeFrom(other.RogueGetInfo);
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
			case 32u:
				Retcode = input.ReadUInt32();
				break;
			case 74u:
				if (hHDLEADBJGN_ == null)
				{
					HHDLEADBJGN = new AHOLOHCLLKD();
				}
				input.ReadMessage(HHDLEADBJGN);
				break;
			case 122u:
				if (rogueGetInfo_ == null)
				{
					RogueGetInfo = new AHNGIOFDJNL();
				}
				input.ReadMessage(RogueGetInfo);
				break;
			}
		}
	}
}
