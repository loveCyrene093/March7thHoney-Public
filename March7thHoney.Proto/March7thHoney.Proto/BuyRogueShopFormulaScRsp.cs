using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BuyRogueShopFormulaScRsp : IMessage<BuyRogueShopFormulaScRsp>, IMessage, IEquatable<BuyRogueShopFormulaScRsp>, IDeepCloneable<BuyRogueShopFormulaScRsp>, IBufferMessage
{
	private static readonly MessageParser<BuyRogueShopFormulaScRsp> _parser = new MessageParser<BuyRogueShopFormulaScRsp>(() => new BuyRogueShopFormulaScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 3;

	private uint retcode_;

	public const int ECJCCKFEFEJFieldNumber = 14;

	private GENOHIJHCDG eCJCCKFEFEJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BuyRogueShopFormulaScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BuyRogueShopFormulaScRspReflection.Descriptor.MessageTypes[0];

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
	public GENOHIJHCDG ECJCCKFEFEJ
	{
		get
		{
			return eCJCCKFEFEJ_;
		}
		set
		{
			eCJCCKFEFEJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BuyRogueShopFormulaScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BuyRogueShopFormulaScRsp(BuyRogueShopFormulaScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		eCJCCKFEFEJ_ = ((other.eCJCCKFEFEJ_ != null) ? other.eCJCCKFEFEJ_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BuyRogueShopFormulaScRsp Clone()
	{
		return new BuyRogueShopFormulaScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BuyRogueShopFormulaScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BuyRogueShopFormulaScRsp other)
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
		if (!object.Equals(ECJCCKFEFEJ, other.ECJCCKFEFEJ))
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
		if (eCJCCKFEFEJ_ != null)
		{
			num ^= ECJCCKFEFEJ.GetHashCode();
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
			output.WriteRawTag(24);
			output.WriteUInt32(Retcode);
		}
		if (eCJCCKFEFEJ_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(ECJCCKFEFEJ);
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
		if (eCJCCKFEFEJ_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ECJCCKFEFEJ);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BuyRogueShopFormulaScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.eCJCCKFEFEJ_ != null)
		{
			if (eCJCCKFEFEJ_ == null)
			{
				ECJCCKFEFEJ = new GENOHIJHCDG();
			}
			ECJCCKFEFEJ.MergeFrom(other.ECJCCKFEFEJ);
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
			case 24u:
				Retcode = input.ReadUInt32();
				break;
			case 114u:
				if (eCJCCKFEFEJ_ == null)
				{
					ECJCCKFEFEJ = new GENOHIJHCDG();
				}
				input.ReadMessage(ECJCCKFEFEJ);
				break;
			}
		}
	}
}
