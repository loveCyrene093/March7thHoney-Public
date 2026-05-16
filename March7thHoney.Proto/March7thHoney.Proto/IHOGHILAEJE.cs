using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class IHOGHILAEJE : IMessage<IHOGHILAEJE>, IMessage, IEquatable<IHOGHILAEJE>, IDeepCloneable<IHOGHILAEJE>, IBufferMessage
{
	private static readonly MessageParser<IHOGHILAEJE> _parser = new MessageParser<IHOGHILAEJE>(() => new IHOGHILAEJE());

	private UnknownFieldSet _unknownFields;

	public const int NMPGNKINPLLFieldNumber = 7;

	private uint nMPGNKINPLL_;

	public const int IGHNAEDJBAGFieldNumber = 11;

	private static readonly FieldCodec<uint> _repeated_iGHNAEDJBAG_codec = FieldCodec.ForUInt32(90u);

	private readonly RepeatedField<uint> iGHNAEDJBAG_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IHOGHILAEJE> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => IHOGHILAEJEReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NMPGNKINPLL
	{
		get
		{
			return nMPGNKINPLL_;
		}
		set
		{
			nMPGNKINPLL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> IGHNAEDJBAG => iGHNAEDJBAG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IHOGHILAEJE()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IHOGHILAEJE(IHOGHILAEJE other)
		: this()
	{
		nMPGNKINPLL_ = other.nMPGNKINPLL_;
		iGHNAEDJBAG_ = other.iGHNAEDJBAG_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IHOGHILAEJE Clone()
	{
		return new IHOGHILAEJE(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as IHOGHILAEJE);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IHOGHILAEJE other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (NMPGNKINPLL != other.NMPGNKINPLL)
		{
			return false;
		}
		if (!iGHNAEDJBAG_.Equals(other.iGHNAEDJBAG_))
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
		if (NMPGNKINPLL != 0)
		{
			num ^= NMPGNKINPLL.GetHashCode();
		}
		num ^= iGHNAEDJBAG_.GetHashCode();
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
		if (NMPGNKINPLL != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(NMPGNKINPLL);
		}
		iGHNAEDJBAG_.WriteTo(ref output, _repeated_iGHNAEDJBAG_codec);
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
		if (NMPGNKINPLL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NMPGNKINPLL);
		}
		num += iGHNAEDJBAG_.CalculateSize(_repeated_iGHNAEDJBAG_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(IHOGHILAEJE other)
	{
		if (other != null)
		{
			if (other.NMPGNKINPLL != 0)
			{
				NMPGNKINPLL = other.NMPGNKINPLL;
			}
			iGHNAEDJBAG_.Add(other.iGHNAEDJBAG_);
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
			case 56u:
				NMPGNKINPLL = input.ReadUInt32();
				break;
			case 88u:
			case 90u:
				iGHNAEDJBAG_.AddEntriesFrom(ref input, _repeated_iGHNAEDJBAG_codec);
				break;
			}
		}
	}
}
