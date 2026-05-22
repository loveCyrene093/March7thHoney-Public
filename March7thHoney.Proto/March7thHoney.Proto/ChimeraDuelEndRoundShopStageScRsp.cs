using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChimeraDuelEndRoundShopStageScRsp : IMessage<ChimeraDuelEndRoundShopStageScRsp>, IMessage, IEquatable<ChimeraDuelEndRoundShopStageScRsp>, IDeepCloneable<ChimeraDuelEndRoundShopStageScRsp>, IBufferMessage
{
	private static readonly MessageParser<ChimeraDuelEndRoundShopStageScRsp> _parser = new MessageParser<ChimeraDuelEndRoundShopStageScRsp>(() => new ChimeraDuelEndRoundShopStageScRsp());

	private UnknownFieldSet _unknownFields;

	public const int OIAPHBBDPHLFieldNumber = 6;

	private DDJOEIBOELH oIAPHBBDPHL_;

	public const int RetcodeFieldNumber = 8;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChimeraDuelEndRoundShopStageScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChimeraDuelEndRoundShopStageScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DDJOEIBOELH OIAPHBBDPHL
	{
		get
		{
			return oIAPHBBDPHL_;
		}
		set
		{
			oIAPHBBDPHL_ = value;
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
	public ChimeraDuelEndRoundShopStageScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChimeraDuelEndRoundShopStageScRsp(ChimeraDuelEndRoundShopStageScRsp other)
		: this()
	{
		oIAPHBBDPHL_ = ((other.oIAPHBBDPHL_ != null) ? other.oIAPHBBDPHL_.Clone() : null);
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChimeraDuelEndRoundShopStageScRsp Clone()
	{
		return new ChimeraDuelEndRoundShopStageScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChimeraDuelEndRoundShopStageScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChimeraDuelEndRoundShopStageScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(OIAPHBBDPHL, other.OIAPHBBDPHL))
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
		if (oIAPHBBDPHL_ != null)
		{
			num ^= OIAPHBBDPHL.GetHashCode();
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
		if (oIAPHBBDPHL_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(OIAPHBBDPHL);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(64);
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
		if (oIAPHBBDPHL_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(OIAPHBBDPHL);
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
	public void MergeFrom(ChimeraDuelEndRoundShopStageScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.oIAPHBBDPHL_ != null)
		{
			if (oIAPHBBDPHL_ == null)
			{
				OIAPHBBDPHL = new DDJOEIBOELH();
			}
			OIAPHBBDPHL.MergeFrom(other.OIAPHBBDPHL);
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
			case 50u:
				if (oIAPHBBDPHL_ == null)
				{
					OIAPHBBDPHL = new DDJOEIBOELH();
				}
				input.ReadMessage(OIAPHBBDPHL);
				break;
			case 64u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
