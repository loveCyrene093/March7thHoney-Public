using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChenLingUseHandCardCsReq : IMessage<ChenLingUseHandCardCsReq>, IMessage, IEquatable<ChenLingUseHandCardCsReq>, IDeepCloneable<ChenLingUseHandCardCsReq>, IBufferMessage
{
	private static readonly MessageParser<ChenLingUseHandCardCsReq> _parser = new MessageParser<ChenLingUseHandCardCsReq>(() => new ChenLingUseHandCardCsReq());

	private UnknownFieldSet _unknownFields;

	public const int JDPHGEJLPPHFieldNumber = 2;

	private FDOEMKPGHFL jDPHGEJLPPH_;

	public const int GDFPBHMMFEAFieldNumber = 15;

	private uint gDFPBHMMFEA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChenLingUseHandCardCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChenLingUseHandCardCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FDOEMKPGHFL JDPHGEJLPPH
	{
		get
		{
			return jDPHGEJLPPH_;
		}
		set
		{
			jDPHGEJLPPH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GDFPBHMMFEA
	{
		get
		{
			return gDFPBHMMFEA_;
		}
		set
		{
			gDFPBHMMFEA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChenLingUseHandCardCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChenLingUseHandCardCsReq(ChenLingUseHandCardCsReq other)
		: this()
	{
		jDPHGEJLPPH_ = ((other.jDPHGEJLPPH_ != null) ? other.jDPHGEJLPPH_.Clone() : null);
		gDFPBHMMFEA_ = other.gDFPBHMMFEA_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChenLingUseHandCardCsReq Clone()
	{
		return new ChenLingUseHandCardCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChenLingUseHandCardCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChenLingUseHandCardCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(JDPHGEJLPPH, other.JDPHGEJLPPH))
		{
			return false;
		}
		if (GDFPBHMMFEA != other.GDFPBHMMFEA)
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
		if (jDPHGEJLPPH_ != null)
		{
			num ^= JDPHGEJLPPH.GetHashCode();
		}
		if (GDFPBHMMFEA != 0)
		{
			num ^= GDFPBHMMFEA.GetHashCode();
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
		if (jDPHGEJLPPH_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(JDPHGEJLPPH);
		}
		if (GDFPBHMMFEA != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(GDFPBHMMFEA);
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
		if (jDPHGEJLPPH_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(JDPHGEJLPPH);
		}
		if (GDFPBHMMFEA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GDFPBHMMFEA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChenLingUseHandCardCsReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.jDPHGEJLPPH_ != null)
		{
			if (jDPHGEJLPPH_ == null)
			{
				JDPHGEJLPPH = new FDOEMKPGHFL();
			}
			JDPHGEJLPPH.MergeFrom(other.JDPHGEJLPPH);
		}
		if (other.GDFPBHMMFEA != 0)
		{
			GDFPBHMMFEA = other.GDFPBHMMFEA;
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
				if (jDPHGEJLPPH_ == null)
				{
					JDPHGEJLPPH = new FDOEMKPGHFL();
				}
				input.ReadMessage(JDPHGEJLPPH);
				break;
			case 120u:
				GDFPBHMMFEA = input.ReadUInt32();
				break;
			}
		}
	}
}
