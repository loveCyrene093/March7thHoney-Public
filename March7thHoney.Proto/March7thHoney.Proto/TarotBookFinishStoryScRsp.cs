using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TarotBookFinishStoryScRsp : IMessage<TarotBookFinishStoryScRsp>, IMessage, IEquatable<TarotBookFinishStoryScRsp>, IDeepCloneable<TarotBookFinishStoryScRsp>, IBufferMessage
{
	private static readonly MessageParser<TarotBookFinishStoryScRsp> _parser = new MessageParser<TarotBookFinishStoryScRsp>(() => new TarotBookFinishStoryScRsp());

	private UnknownFieldSet _unknownFields;

	public const int CPEMLIAGBKBFieldNumber = 11;

	private CDHOKMAAMFD cPEMLIAGBKB_;

	public const int MAFMCIPAIKKFieldNumber = 12;

	private uint mAFMCIPAIKK_;

	public const int RetcodeFieldNumber = 15;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TarotBookFinishStoryScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TarotBookFinishStoryScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CDHOKMAAMFD CPEMLIAGBKB
	{
		get
		{
			return cPEMLIAGBKB_;
		}
		set
		{
			cPEMLIAGBKB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MAFMCIPAIKK
	{
		get
		{
			return mAFMCIPAIKK_;
		}
		set
		{
			mAFMCIPAIKK_ = value;
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
	public TarotBookFinishStoryScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TarotBookFinishStoryScRsp(TarotBookFinishStoryScRsp other)
		: this()
	{
		cPEMLIAGBKB_ = ((other.cPEMLIAGBKB_ != null) ? other.cPEMLIAGBKB_.Clone() : null);
		mAFMCIPAIKK_ = other.mAFMCIPAIKK_;
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TarotBookFinishStoryScRsp Clone()
	{
		return new TarotBookFinishStoryScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TarotBookFinishStoryScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TarotBookFinishStoryScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(CPEMLIAGBKB, other.CPEMLIAGBKB))
		{
			return false;
		}
		if (MAFMCIPAIKK != other.MAFMCIPAIKK)
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
		if (cPEMLIAGBKB_ != null)
		{
			num ^= CPEMLIAGBKB.GetHashCode();
		}
		if (MAFMCIPAIKK != 0)
		{
			num ^= MAFMCIPAIKK.GetHashCode();
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
		if (cPEMLIAGBKB_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(CPEMLIAGBKB);
		}
		if (MAFMCIPAIKK != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(MAFMCIPAIKK);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(120);
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
		if (cPEMLIAGBKB_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CPEMLIAGBKB);
		}
		if (MAFMCIPAIKK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MAFMCIPAIKK);
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
	public void MergeFrom(TarotBookFinishStoryScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.cPEMLIAGBKB_ != null)
		{
			if (cPEMLIAGBKB_ == null)
			{
				CPEMLIAGBKB = new CDHOKMAAMFD();
			}
			CPEMLIAGBKB.MergeFrom(other.CPEMLIAGBKB);
		}
		if (other.MAFMCIPAIKK != 0)
		{
			MAFMCIPAIKK = other.MAFMCIPAIKK;
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
			case 90u:
				if (cPEMLIAGBKB_ == null)
				{
					CPEMLIAGBKB = new CDHOKMAAMFD();
				}
				input.ReadMessage(CPEMLIAGBKB);
				break;
			case 96u:
				MAFMCIPAIKK = input.ReadUInt32();
				break;
			case 120u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
