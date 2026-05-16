using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BuyRogueShopMiracleScRsp : IMessage<BuyRogueShopMiracleScRsp>, IMessage, IEquatable<BuyRogueShopMiracleScRsp>, IDeepCloneable<BuyRogueShopMiracleScRsp>, IBufferMessage
{
	private static readonly MessageParser<BuyRogueShopMiracleScRsp> _parser = new MessageParser<BuyRogueShopMiracleScRsp>(() => new BuyRogueShopMiracleScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 7;

	private uint retcode_;

	public const int FEILNIKNPCBFieldNumber = 11;

	private IEMKPMMJLLE fEILNIKNPCB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BuyRogueShopMiracleScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BuyRogueShopMiracleScRspReflection.Descriptor.MessageTypes[0];

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
	public IEMKPMMJLLE FEILNIKNPCB
	{
		get
		{
			return fEILNIKNPCB_;
		}
		set
		{
			fEILNIKNPCB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BuyRogueShopMiracleScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BuyRogueShopMiracleScRsp(BuyRogueShopMiracleScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		fEILNIKNPCB_ = ((other.fEILNIKNPCB_ != null) ? other.fEILNIKNPCB_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BuyRogueShopMiracleScRsp Clone()
	{
		return new BuyRogueShopMiracleScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BuyRogueShopMiracleScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BuyRogueShopMiracleScRsp other)
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
		if (!object.Equals(FEILNIKNPCB, other.FEILNIKNPCB))
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
		if (fEILNIKNPCB_ != null)
		{
			num ^= FEILNIKNPCB.GetHashCode();
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
			output.WriteRawTag(56);
			output.WriteUInt32(Retcode);
		}
		if (fEILNIKNPCB_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(FEILNIKNPCB);
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
		if (fEILNIKNPCB_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FEILNIKNPCB);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BuyRogueShopMiracleScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.fEILNIKNPCB_ != null)
		{
			if (fEILNIKNPCB_ == null)
			{
				FEILNIKNPCB = new IEMKPMMJLLE();
			}
			FEILNIKNPCB.MergeFrom(other.FEILNIKNPCB);
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
			case 56u:
				Retcode = input.ReadUInt32();
				break;
			case 90u:
				if (fEILNIKNPCB_ == null)
				{
					FEILNIKNPCB = new IEMKPMMJLLE();
				}
				input.ReadMessage(FEILNIKNPCB);
				break;
			}
		}
	}
}
