using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MFMEMDJKDAF : IMessage<MFMEMDJKDAF>, IMessage, IEquatable<MFMEMDJKDAF>, IDeepCloneable<MFMEMDJKDAF>, IBufferMessage
{
	private static readonly MessageParser<MFMEMDJKDAF> _parser = new MessageParser<MFMEMDJKDAF>(() => new MFMEMDJKDAF());

	private UnknownFieldSet _unknownFields;

	public const int EGCOGPACJODFieldNumber = 4;

	private static readonly FieldCodec<uint> _repeated_eGCOGPACJOD_codec = FieldCodec.ForUInt32(34u);

	private readonly RepeatedField<uint> eGCOGPACJOD_ = new RepeatedField<uint>();

	public const int EPMFDGPKPHJFieldNumber = 6;

	private static readonly FieldCodec<uint> _repeated_ePMFDGPKPHJ_codec = FieldCodec.ForUInt32(50u);

	private readonly RepeatedField<uint> ePMFDGPKPHJ_ = new RepeatedField<uint>();

	public const int DCFGOFNBLCMFieldNumber = 10;

	private DGMLAAIHBFC dCFGOFNBLCM_;

	public const int FKOEBMADJEKFieldNumber = 13;

	private ACFIGFIILOJ fKOEBMADJEK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MFMEMDJKDAF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MFMEMDJKDAFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> EGCOGPACJOD => eGCOGPACJOD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> EPMFDGPKPHJ => ePMFDGPKPHJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DGMLAAIHBFC DCFGOFNBLCM
	{
		get
		{
			return dCFGOFNBLCM_;
		}
		set
		{
			dCFGOFNBLCM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ACFIGFIILOJ FKOEBMADJEK
	{
		get
		{
			return fKOEBMADJEK_;
		}
		set
		{
			fKOEBMADJEK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MFMEMDJKDAF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MFMEMDJKDAF(MFMEMDJKDAF other)
		: this()
	{
		eGCOGPACJOD_ = other.eGCOGPACJOD_.Clone();
		ePMFDGPKPHJ_ = other.ePMFDGPKPHJ_.Clone();
		dCFGOFNBLCM_ = ((other.dCFGOFNBLCM_ != null) ? other.dCFGOFNBLCM_.Clone() : null);
		fKOEBMADJEK_ = ((other.fKOEBMADJEK_ != null) ? other.fKOEBMADJEK_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MFMEMDJKDAF Clone()
	{
		return new MFMEMDJKDAF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MFMEMDJKDAF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MFMEMDJKDAF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!eGCOGPACJOD_.Equals(other.eGCOGPACJOD_))
		{
			return false;
		}
		if (!ePMFDGPKPHJ_.Equals(other.ePMFDGPKPHJ_))
		{
			return false;
		}
		if (!object.Equals(DCFGOFNBLCM, other.DCFGOFNBLCM))
		{
			return false;
		}
		if (!object.Equals(FKOEBMADJEK, other.FKOEBMADJEK))
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
		num ^= eGCOGPACJOD_.GetHashCode();
		num ^= ePMFDGPKPHJ_.GetHashCode();
		if (dCFGOFNBLCM_ != null)
		{
			num ^= DCFGOFNBLCM.GetHashCode();
		}
		if (fKOEBMADJEK_ != null)
		{
			num ^= FKOEBMADJEK.GetHashCode();
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
		eGCOGPACJOD_.WriteTo(ref output, _repeated_eGCOGPACJOD_codec);
		ePMFDGPKPHJ_.WriteTo(ref output, _repeated_ePMFDGPKPHJ_codec);
		if (dCFGOFNBLCM_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(DCFGOFNBLCM);
		}
		if (fKOEBMADJEK_ != null)
		{
			output.WriteRawTag(106);
			output.WriteMessage(FKOEBMADJEK);
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
		num += eGCOGPACJOD_.CalculateSize(_repeated_eGCOGPACJOD_codec);
		num += ePMFDGPKPHJ_.CalculateSize(_repeated_ePMFDGPKPHJ_codec);
		if (dCFGOFNBLCM_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DCFGOFNBLCM);
		}
		if (fKOEBMADJEK_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FKOEBMADJEK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MFMEMDJKDAF other)
	{
		if (other == null)
		{
			return;
		}
		eGCOGPACJOD_.Add(other.eGCOGPACJOD_);
		ePMFDGPKPHJ_.Add(other.ePMFDGPKPHJ_);
		if (other.dCFGOFNBLCM_ != null)
		{
			if (dCFGOFNBLCM_ == null)
			{
				DCFGOFNBLCM = new DGMLAAIHBFC();
			}
			DCFGOFNBLCM.MergeFrom(other.DCFGOFNBLCM);
		}
		if (other.fKOEBMADJEK_ != null)
		{
			if (fKOEBMADJEK_ == null)
			{
				FKOEBMADJEK = new ACFIGFIILOJ();
			}
			FKOEBMADJEK.MergeFrom(other.FKOEBMADJEK);
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
			case 32u:
			case 34u:
				eGCOGPACJOD_.AddEntriesFrom(ref input, _repeated_eGCOGPACJOD_codec);
				break;
			case 48u:
			case 50u:
				ePMFDGPKPHJ_.AddEntriesFrom(ref input, _repeated_ePMFDGPKPHJ_codec);
				break;
			case 82u:
				if (dCFGOFNBLCM_ == null)
				{
					DCFGOFNBLCM = new DGMLAAIHBFC();
				}
				input.ReadMessage(DCFGOFNBLCM);
				break;
			case 106u:
				if (fKOEBMADJEK_ == null)
				{
					FKOEBMADJEK = new ACFIGFIILOJ();
				}
				input.ReadMessage(FKOEBMADJEK);
				break;
			}
		}
	}
}
