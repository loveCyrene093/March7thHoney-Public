using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RogueTournQueryScRsp : IMessage<RogueTournQueryScRsp>, IMessage, IEquatable<RogueTournQueryScRsp>, IDeepCloneable<RogueTournQueryScRsp>, IBufferMessage
{
	private static readonly MessageParser<RogueTournQueryScRsp> _parser = new MessageParser<RogueTournQueryScRsp>(() => new RogueTournQueryScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 1;

	private uint retcode_;

	public const int RogueGetInfoFieldNumber = 7;

	private BEBEOMBMDFB rogueGetInfo_;

	public const int HHDLEADBJGNFieldNumber = 13;

	private APMHDGPDGNP hHDLEADBJGN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RogueTournQueryScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RogueTournQueryScRspReflection.Descriptor.MessageTypes[0];

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
	public BEBEOMBMDFB RogueGetInfo
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
	public APMHDGPDGNP HHDLEADBJGN
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
	public RogueTournQueryScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueTournQueryScRsp(RogueTournQueryScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		rogueGetInfo_ = ((other.rogueGetInfo_ != null) ? other.rogueGetInfo_.Clone() : null);
		hHDLEADBJGN_ = ((other.hHDLEADBJGN_ != null) ? other.hHDLEADBJGN_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueTournQueryScRsp Clone()
	{
		return new RogueTournQueryScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RogueTournQueryScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RogueTournQueryScRsp other)
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
		if (!object.Equals(RogueGetInfo, other.RogueGetInfo))
		{
			return false;
		}
		if (!object.Equals(HHDLEADBJGN, other.HHDLEADBJGN))
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
		if (rogueGetInfo_ != null)
		{
			num ^= RogueGetInfo.GetHashCode();
		}
		if (hHDLEADBJGN_ != null)
		{
			num ^= HHDLEADBJGN.GetHashCode();
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
			output.WriteRawTag(8);
			output.WriteUInt32(Retcode);
		}
		if (rogueGetInfo_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(RogueGetInfo);
		}
		if (hHDLEADBJGN_ != null)
		{
			output.WriteRawTag(106);
			output.WriteMessage(HHDLEADBJGN);
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
		if (rogueGetInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(RogueGetInfo);
		}
		if (hHDLEADBJGN_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HHDLEADBJGN);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RogueTournQueryScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.rogueGetInfo_ != null)
		{
			if (rogueGetInfo_ == null)
			{
				RogueGetInfo = new BEBEOMBMDFB();
			}
			RogueGetInfo.MergeFrom(other.RogueGetInfo);
		}
		if (other.hHDLEADBJGN_ != null)
		{
			if (hHDLEADBJGN_ == null)
			{
				HHDLEADBJGN = new APMHDGPDGNP();
			}
			HHDLEADBJGN.MergeFrom(other.HHDLEADBJGN);
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
				Retcode = input.ReadUInt32();
				break;
			case 58u:
				if (rogueGetInfo_ == null)
				{
					RogueGetInfo = new BEBEOMBMDFB();
				}
				input.ReadMessage(RogueGetInfo);
				break;
			case 106u:
				if (hHDLEADBJGN_ == null)
				{
					HHDLEADBJGN = new APMHDGPDGNP();
				}
				input.ReadMessage(HHDLEADBJGN);
				break;
			}
		}
	}
}
