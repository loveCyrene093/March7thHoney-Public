using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CLJAIHNBKEM : IMessage<CLJAIHNBKEM>, IMessage, IEquatable<CLJAIHNBKEM>, IDeepCloneable<CLJAIHNBKEM>, IBufferMessage
{
	private static readonly MessageParser<CLJAIHNBKEM> _parser = new MessageParser<CLJAIHNBKEM>(() => new CLJAIHNBKEM());

	private UnknownFieldSet _unknownFields;

	public const int BFCBGPEICHGFieldNumber = 1;

	private GGCFFJGCPKD bFCBGPEICHG_;

	public const int LineupListFieldNumber = 2;

	private static readonly FieldCodec<JAFMFGJLGGA> _repeated_lineupList_codec = FieldCodec.ForMessage(18u, JAFMFGJLGGA.Parser);

	private readonly RepeatedField<JAFMFGJLGGA> lineupList_ = new RepeatedField<JAFMFGJLGGA>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CLJAIHNBKEM> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CLJAIHNBKEMReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GGCFFJGCPKD BFCBGPEICHG
	{
		get
		{
			return bFCBGPEICHG_;
		}
		set
		{
			bFCBGPEICHG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<JAFMFGJLGGA> LineupList => lineupList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CLJAIHNBKEM()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CLJAIHNBKEM(CLJAIHNBKEM other)
		: this()
	{
		bFCBGPEICHG_ = other.bFCBGPEICHG_;
		lineupList_ = other.lineupList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CLJAIHNBKEM Clone()
	{
		return new CLJAIHNBKEM(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CLJAIHNBKEM);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CLJAIHNBKEM other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (BFCBGPEICHG != other.BFCBGPEICHG)
		{
			return false;
		}
		if (!lineupList_.Equals(other.lineupList_))
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
		if (BFCBGPEICHG != GGCFFJGCPKD.Pcpdhelpkem)
		{
			num ^= BFCBGPEICHG.GetHashCode();
		}
		num ^= lineupList_.GetHashCode();
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
		if (BFCBGPEICHG != GGCFFJGCPKD.Pcpdhelpkem)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)BFCBGPEICHG);
		}
		lineupList_.WriteTo(ref output, _repeated_lineupList_codec);
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
		if (BFCBGPEICHG != GGCFFJGCPKD.Pcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)BFCBGPEICHG);
		}
		num += lineupList_.CalculateSize(_repeated_lineupList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CLJAIHNBKEM other)
	{
		if (other != null)
		{
			if (other.BFCBGPEICHG != GGCFFJGCPKD.Pcpdhelpkem)
			{
				BFCBGPEICHG = other.BFCBGPEICHG;
			}
			lineupList_.Add(other.lineupList_);
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
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
				BFCBGPEICHG = (GGCFFJGCPKD)input.ReadEnum();
				break;
			case 18u:
				lineupList_.AddEntriesFrom(ref input, _repeated_lineupList_codec);
				break;
			}
		}
	}
}
