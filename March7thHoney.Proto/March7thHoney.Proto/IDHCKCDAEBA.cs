using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class IDHCKCDAEBA : IMessage<IDHCKCDAEBA>, IMessage, IEquatable<IDHCKCDAEBA>, IDeepCloneable<IDHCKCDAEBA>, IBufferMessage
{
	private static readonly MessageParser<IDHCKCDAEBA> _parser = new MessageParser<IDHCKCDAEBA>(() => new IDHCKCDAEBA());

	private UnknownFieldSet _unknownFields;

	public const int FCHPJKAIBHBFieldNumber = 5;

	private uint fCHPJKAIBHB_;

	public const int OIJDLFINILCFieldNumber = 8;

	private uint oIJDLFINILC_;

	public const int CGMGJOGIMGHFieldNumber = 12;

	private uint cGMGJOGIMGH_;

	public const int INHKPNNKMNJFieldNumber = 14;

	private static readonly FieldCodec<uint> _repeated_iNHKPNNKMNJ_codec = FieldCodec.ForUInt32(114u);

	private readonly RepeatedField<uint> iNHKPNNKMNJ_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IDHCKCDAEBA> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => IDHCKCDAEBAReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FCHPJKAIBHB
	{
		get
		{
			return fCHPJKAIBHB_;
		}
		set
		{
			fCHPJKAIBHB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OIJDLFINILC
	{
		get
		{
			return oIJDLFINILC_;
		}
		set
		{
			oIJDLFINILC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CGMGJOGIMGH
	{
		get
		{
			return cGMGJOGIMGH_;
		}
		set
		{
			cGMGJOGIMGH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> INHKPNNKMNJ => iNHKPNNKMNJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IDHCKCDAEBA()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IDHCKCDAEBA(IDHCKCDAEBA other)
		: this()
	{
		fCHPJKAIBHB_ = other.fCHPJKAIBHB_;
		oIJDLFINILC_ = other.oIJDLFINILC_;
		cGMGJOGIMGH_ = other.cGMGJOGIMGH_;
		iNHKPNNKMNJ_ = other.iNHKPNNKMNJ_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IDHCKCDAEBA Clone()
	{
		return new IDHCKCDAEBA(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as IDHCKCDAEBA);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IDHCKCDAEBA other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (FCHPJKAIBHB != other.FCHPJKAIBHB)
		{
			return false;
		}
		if (OIJDLFINILC != other.OIJDLFINILC)
		{
			return false;
		}
		if (CGMGJOGIMGH != other.CGMGJOGIMGH)
		{
			return false;
		}
		if (!iNHKPNNKMNJ_.Equals(other.iNHKPNNKMNJ_))
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
		if (FCHPJKAIBHB != 0)
		{
			num ^= FCHPJKAIBHB.GetHashCode();
		}
		if (OIJDLFINILC != 0)
		{
			num ^= OIJDLFINILC.GetHashCode();
		}
		if (CGMGJOGIMGH != 0)
		{
			num ^= CGMGJOGIMGH.GetHashCode();
		}
		num ^= iNHKPNNKMNJ_.GetHashCode();
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
		if (FCHPJKAIBHB != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(FCHPJKAIBHB);
		}
		if (OIJDLFINILC != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(OIJDLFINILC);
		}
		if (CGMGJOGIMGH != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(CGMGJOGIMGH);
		}
		iNHKPNNKMNJ_.WriteTo(ref output, _repeated_iNHKPNNKMNJ_codec);
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
		if (FCHPJKAIBHB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FCHPJKAIBHB);
		}
		if (OIJDLFINILC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OIJDLFINILC);
		}
		if (CGMGJOGIMGH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CGMGJOGIMGH);
		}
		num += iNHKPNNKMNJ_.CalculateSize(_repeated_iNHKPNNKMNJ_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(IDHCKCDAEBA other)
	{
		if (other != null)
		{
			if (other.FCHPJKAIBHB != 0)
			{
				FCHPJKAIBHB = other.FCHPJKAIBHB;
			}
			if (other.OIJDLFINILC != 0)
			{
				OIJDLFINILC = other.OIJDLFINILC;
			}
			if (other.CGMGJOGIMGH != 0)
			{
				CGMGJOGIMGH = other.CGMGJOGIMGH;
			}
			iNHKPNNKMNJ_.Add(other.iNHKPNNKMNJ_);
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
			case 40u:
				FCHPJKAIBHB = input.ReadUInt32();
				break;
			case 64u:
				OIJDLFINILC = input.ReadUInt32();
				break;
			case 96u:
				CGMGJOGIMGH = input.ReadUInt32();
				break;
			case 112u:
			case 114u:
				iNHKPNNKMNJ_.AddEntriesFrom(ref input, _repeated_iNHKPNNKMNJ_codec);
				break;
			}
		}
	}
}
