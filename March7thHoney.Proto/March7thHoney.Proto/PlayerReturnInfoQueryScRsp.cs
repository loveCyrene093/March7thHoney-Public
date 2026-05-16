using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PlayerReturnInfoQueryScRsp : IMessage<PlayerReturnInfoQueryScRsp>, IMessage, IEquatable<PlayerReturnInfoQueryScRsp>, IDeepCloneable<PlayerReturnInfoQueryScRsp>, IBufferMessage
{
	private static readonly MessageParser<PlayerReturnInfoQueryScRsp> _parser = new MessageParser<PlayerReturnInfoQueryScRsp>(() => new PlayerReturnInfoQueryScRsp());

	private UnknownFieldSet _unknownFields;

	public const int CAAFBGGIBKHFieldNumber = 2;

	private KKNDEDPDFFL cAAFBGGIBKH_;

	public const int RetcodeFieldNumber = 7;

	private uint retcode_;

	public const int BJMNPNFNHOAFieldNumber = 15;

	private uint bJMNPNFNHOA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PlayerReturnInfoQueryScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PlayerReturnInfoQueryScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KKNDEDPDFFL CAAFBGGIBKH
	{
		get
		{
			return cAAFBGGIBKH_;
		}
		set
		{
			cAAFBGGIBKH_ = value;
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
	public uint BJMNPNFNHOA
	{
		get
		{
			return bJMNPNFNHOA_;
		}
		set
		{
			bJMNPNFNHOA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerReturnInfoQueryScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerReturnInfoQueryScRsp(PlayerReturnInfoQueryScRsp other)
		: this()
	{
		cAAFBGGIBKH_ = ((other.cAAFBGGIBKH_ != null) ? other.cAAFBGGIBKH_.Clone() : null);
		retcode_ = other.retcode_;
		bJMNPNFNHOA_ = other.bJMNPNFNHOA_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerReturnInfoQueryScRsp Clone()
	{
		return new PlayerReturnInfoQueryScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PlayerReturnInfoQueryScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PlayerReturnInfoQueryScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(CAAFBGGIBKH, other.CAAFBGGIBKH))
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (BJMNPNFNHOA != other.BJMNPNFNHOA)
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
		if (cAAFBGGIBKH_ != null)
		{
			num ^= CAAFBGGIBKH.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (BJMNPNFNHOA != 0)
		{
			num ^= BJMNPNFNHOA.GetHashCode();
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
		if (cAAFBGGIBKH_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(CAAFBGGIBKH);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(Retcode);
		}
		if (BJMNPNFNHOA != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(BJMNPNFNHOA);
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
		if (cAAFBGGIBKH_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CAAFBGGIBKH);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (BJMNPNFNHOA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BJMNPNFNHOA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PlayerReturnInfoQueryScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.cAAFBGGIBKH_ != null)
		{
			if (cAAFBGGIBKH_ == null)
			{
				CAAFBGGIBKH = new KKNDEDPDFFL();
			}
			CAAFBGGIBKH.MergeFrom(other.CAAFBGGIBKH);
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.BJMNPNFNHOA != 0)
		{
			BJMNPNFNHOA = other.BJMNPNFNHOA;
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
			case 18u:
				if (cAAFBGGIBKH_ == null)
				{
					CAAFBGGIBKH = new KKNDEDPDFFL();
				}
				input.ReadMessage(CAAFBGGIBKH);
				break;
			case 56u:
				Retcode = input.ReadUInt32();
				break;
			case 120u:
				BJMNPNFNHOA = input.ReadUInt32();
				break;
			}
		}
	}
}
