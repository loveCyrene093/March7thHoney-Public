using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BAACEGAEDLI : IMessage<BAACEGAEDLI>, IMessage, IEquatable<BAACEGAEDLI>, IDeepCloneable<BAACEGAEDLI>, IBufferMessage
{
	private static readonly MessageParser<BAACEGAEDLI> _parser = new MessageParser<BAACEGAEDLI>(() => new BAACEGAEDLI());

	private UnknownFieldSet _unknownFields;

	public const int IMBOKGFIACAFieldNumber = 2;

	private uint iMBOKGFIACA_;

	public const int LDKGJBALGKCFieldNumber = 9;

	private CJPFNAFLAPD lDKGJBALGKC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BAACEGAEDLI> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BAACEGAEDLIReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IMBOKGFIACA
	{
		get
		{
			return iMBOKGFIACA_;
		}
		set
		{
			iMBOKGFIACA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CJPFNAFLAPD LDKGJBALGKC
	{
		get
		{
			return lDKGJBALGKC_;
		}
		set
		{
			lDKGJBALGKC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BAACEGAEDLI()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BAACEGAEDLI(BAACEGAEDLI other)
		: this()
	{
		iMBOKGFIACA_ = other.iMBOKGFIACA_;
		lDKGJBALGKC_ = ((other.lDKGJBALGKC_ != null) ? other.lDKGJBALGKC_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BAACEGAEDLI Clone()
	{
		return new BAACEGAEDLI(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BAACEGAEDLI);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BAACEGAEDLI other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IMBOKGFIACA != other.IMBOKGFIACA)
		{
			return false;
		}
		if (!object.Equals(LDKGJBALGKC, other.LDKGJBALGKC))
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
		if (IMBOKGFIACA != 0)
		{
			num ^= IMBOKGFIACA.GetHashCode();
		}
		if (lDKGJBALGKC_ != null)
		{
			num ^= LDKGJBALGKC.GetHashCode();
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
		if (IMBOKGFIACA != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(IMBOKGFIACA);
		}
		if (lDKGJBALGKC_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(LDKGJBALGKC);
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
		if (IMBOKGFIACA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IMBOKGFIACA);
		}
		if (lDKGJBALGKC_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LDKGJBALGKC);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BAACEGAEDLI other)
	{
		if (other == null)
		{
			return;
		}
		if (other.IMBOKGFIACA != 0)
		{
			IMBOKGFIACA = other.IMBOKGFIACA;
		}
		if (other.lDKGJBALGKC_ != null)
		{
			if (lDKGJBALGKC_ == null)
			{
				LDKGJBALGKC = new CJPFNAFLAPD();
			}
			LDKGJBALGKC.MergeFrom(other.LDKGJBALGKC);
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
			case 16u:
				IMBOKGFIACA = input.ReadUInt32();
				break;
			case 74u:
				if (lDKGJBALGKC_ == null)
				{
					LDKGJBALGKC = new CJPFNAFLAPD();
				}
				input.ReadMessage(LDKGJBALGKC);
				break;
			}
		}
	}
}
