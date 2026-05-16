using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DLGLHKKIJJK : IMessage<DLGLHKKIJJK>, IMessage, IEquatable<DLGLHKKIJJK>, IDeepCloneable<DLGLHKKIJJK>, IBufferMessage
{
	private static readonly MessageParser<DLGLHKKIJJK> _parser = new MessageParser<DLGLHKKIJJK>(() => new DLGLHKKIJJK());

	private UnknownFieldSet _unknownFields;

	public const int DEEEMPDCIEKFieldNumber = 8;

	private static readonly FieldCodec<uint> _repeated_dEEEMPDCIEK_codec = FieldCodec.ForUInt32(66u);

	private readonly RepeatedField<uint> dEEEMPDCIEK_ = new RepeatedField<uint>();

	public const int EPFPKCBDFOOFieldNumber = 12;

	private uint ePFPKCBDFOO_;

	public const int COBFABGOLFEFieldNumber = 13;

	private uint cOBFABGOLFE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DLGLHKKIJJK> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DLGLHKKIJJKReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> DEEEMPDCIEK => dEEEMPDCIEK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EPFPKCBDFOO
	{
		get
		{
			return ePFPKCBDFOO_;
		}
		set
		{
			ePFPKCBDFOO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint COBFABGOLFE
	{
		get
		{
			return cOBFABGOLFE_;
		}
		set
		{
			cOBFABGOLFE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DLGLHKKIJJK()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DLGLHKKIJJK(DLGLHKKIJJK other)
		: this()
	{
		dEEEMPDCIEK_ = other.dEEEMPDCIEK_.Clone();
		ePFPKCBDFOO_ = other.ePFPKCBDFOO_;
		cOBFABGOLFE_ = other.cOBFABGOLFE_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DLGLHKKIJJK Clone()
	{
		return new DLGLHKKIJJK(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DLGLHKKIJJK);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DLGLHKKIJJK other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!dEEEMPDCIEK_.Equals(other.dEEEMPDCIEK_))
		{
			return false;
		}
		if (EPFPKCBDFOO != other.EPFPKCBDFOO)
		{
			return false;
		}
		if (COBFABGOLFE != other.COBFABGOLFE)
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
		num ^= dEEEMPDCIEK_.GetHashCode();
		if (EPFPKCBDFOO != 0)
		{
			num ^= EPFPKCBDFOO.GetHashCode();
		}
		if (COBFABGOLFE != 0)
		{
			num ^= COBFABGOLFE.GetHashCode();
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
		dEEEMPDCIEK_.WriteTo(ref output, _repeated_dEEEMPDCIEK_codec);
		if (EPFPKCBDFOO != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(EPFPKCBDFOO);
		}
		if (COBFABGOLFE != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(COBFABGOLFE);
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
		num += dEEEMPDCIEK_.CalculateSize(_repeated_dEEEMPDCIEK_codec);
		if (EPFPKCBDFOO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EPFPKCBDFOO);
		}
		if (COBFABGOLFE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(COBFABGOLFE);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DLGLHKKIJJK other)
	{
		if (other != null)
		{
			dEEEMPDCIEK_.Add(other.dEEEMPDCIEK_);
			if (other.EPFPKCBDFOO != 0)
			{
				EPFPKCBDFOO = other.EPFPKCBDFOO;
			}
			if (other.COBFABGOLFE != 0)
			{
				COBFABGOLFE = other.COBFABGOLFE;
			}
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
			case 64u:
			case 66u:
				dEEEMPDCIEK_.AddEntriesFrom(ref input, _repeated_dEEEMPDCIEK_codec);
				break;
			case 96u:
				EPFPKCBDFOO = input.ReadUInt32();
				break;
			case 104u:
				COBFABGOLFE = input.ReadUInt32();
				break;
			}
		}
	}
}
