using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TakeKilledPunkLordMonsterScoreCsReq : IMessage<TakeKilledPunkLordMonsterScoreCsReq>, IMessage, IEquatable<TakeKilledPunkLordMonsterScoreCsReq>, IDeepCloneable<TakeKilledPunkLordMonsterScoreCsReq>, IBufferMessage
{
	private static readonly MessageParser<TakeKilledPunkLordMonsterScoreCsReq> _parser = new MessageParser<TakeKilledPunkLordMonsterScoreCsReq>(() => new TakeKilledPunkLordMonsterScoreCsReq());

	private UnknownFieldSet _unknownFields;

	public const int JIPALBLOPFIFieldNumber = 9;

	private JLLIDDIBOHI jIPALBLOPFI_;

	public const int MDNFLHMOLNBFieldNumber = 11;

	private bool mDNFLHMOLNB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TakeKilledPunkLordMonsterScoreCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TakeKilledPunkLordMonsterScoreCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JLLIDDIBOHI JIPALBLOPFI
	{
		get
		{
			return jIPALBLOPFI_;
		}
		set
		{
			jIPALBLOPFI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool MDNFLHMOLNB
	{
		get
		{
			return mDNFLHMOLNB_;
		}
		set
		{
			mDNFLHMOLNB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TakeKilledPunkLordMonsterScoreCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TakeKilledPunkLordMonsterScoreCsReq(TakeKilledPunkLordMonsterScoreCsReq other)
		: this()
	{
		jIPALBLOPFI_ = ((other.jIPALBLOPFI_ != null) ? other.jIPALBLOPFI_.Clone() : null);
		mDNFLHMOLNB_ = other.mDNFLHMOLNB_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TakeKilledPunkLordMonsterScoreCsReq Clone()
	{
		return new TakeKilledPunkLordMonsterScoreCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TakeKilledPunkLordMonsterScoreCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TakeKilledPunkLordMonsterScoreCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(JIPALBLOPFI, other.JIPALBLOPFI))
		{
			return false;
		}
		if (MDNFLHMOLNB != other.MDNFLHMOLNB)
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
		if (jIPALBLOPFI_ != null)
		{
			num ^= JIPALBLOPFI.GetHashCode();
		}
		if (MDNFLHMOLNB)
		{
			num ^= MDNFLHMOLNB.GetHashCode();
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
		if (jIPALBLOPFI_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(JIPALBLOPFI);
		}
		if (MDNFLHMOLNB)
		{
			output.WriteRawTag(88);
			output.WriteBool(MDNFLHMOLNB);
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
		if (jIPALBLOPFI_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(JIPALBLOPFI);
		}
		if (MDNFLHMOLNB)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TakeKilledPunkLordMonsterScoreCsReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.jIPALBLOPFI_ != null)
		{
			if (jIPALBLOPFI_ == null)
			{
				JIPALBLOPFI = new JLLIDDIBOHI();
			}
			JIPALBLOPFI.MergeFrom(other.JIPALBLOPFI);
		}
		if (other.MDNFLHMOLNB)
		{
			MDNFLHMOLNB = other.MDNFLHMOLNB;
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
			case 74u:
				if (jIPALBLOPFI_ == null)
				{
					JIPALBLOPFI = new JLLIDDIBOHI();
				}
				input.ReadMessage(JIPALBLOPFI);
				break;
			case 88u:
				MDNFLHMOLNB = input.ReadBool();
				break;
			}
		}
	}
}
