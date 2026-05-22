using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BDEMABPLPKO : IMessage<BDEMABPLPKO>, IMessage, IEquatable<BDEMABPLPKO>, IDeepCloneable<BDEMABPLPKO>, IBufferMessage
{
	private static readonly MessageParser<BDEMABPLPKO> _parser = new MessageParser<BDEMABPLPKO>(() => new BDEMABPLPKO());

	private UnknownFieldSet _unknownFields;

	public const int BPCKFLJIGCIFieldNumber = 3;

	private static readonly FieldCodec<JIPACDEJKJC> _repeated_bPCKFLJIGCI_codec = FieldCodec.ForMessage(26u, JIPACDEJKJC.Parser);

	private readonly RepeatedField<JIPACDEJKJC> bPCKFLJIGCI_ = new RepeatedField<JIPACDEJKJC>();

	public const int CFIONKKIPJLFieldNumber = 4;

	private bool cFIONKKIPJL_;

	public const int BFNPCJOMGFLFieldNumber = 5;

	private EFEGKDHEMFN bFNPCJOMGFL_;

	public const int GAFPECGGICCFieldNumber = 6;

	private uint gAFPECGGICC_;

	public const int HasPassedFieldNumber = 9;

	private bool hasPassed_;

	public const int DNNHCNCKJCMFieldNumber = 11;

	private long dNNHCNCKJCM_;

	public const int KBHEGBCAAMGFieldNumber = 14;

	private static readonly MapField<uint, uint>.Codec _map_kBHEGBCAAMG_codec = new MapField<uint, uint>.Codec(FieldCodec.ForUInt32(8u, 0u), FieldCodec.ForUInt32(16u, 0u), 114u);

	private readonly MapField<uint, uint> kBHEGBCAAMG_ = new MapField<uint, uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BDEMABPLPKO> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BDEMABPLPKOReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<JIPACDEJKJC> BPCKFLJIGCI => bPCKFLJIGCI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool CFIONKKIPJL
	{
		get
		{
			return cFIONKKIPJL_;
		}
		set
		{
			cFIONKKIPJL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EFEGKDHEMFN BFNPCJOMGFL
	{
		get
		{
			return bFNPCJOMGFL_;
		}
		set
		{
			bFNPCJOMGFL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GAFPECGGICC
	{
		get
		{
			return gAFPECGGICC_;
		}
		set
		{
			gAFPECGGICC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasPassed
	{
		get
		{
			return hasPassed_;
		}
		set
		{
			hasPassed_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long DNNHCNCKJCM
	{
		get
		{
			return dNNHCNCKJCM_;
		}
		set
		{
			dNNHCNCKJCM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<uint, uint> KBHEGBCAAMG => kBHEGBCAAMG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BDEMABPLPKO()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BDEMABPLPKO(BDEMABPLPKO other)
		: this()
	{
		bPCKFLJIGCI_ = other.bPCKFLJIGCI_.Clone();
		cFIONKKIPJL_ = other.cFIONKKIPJL_;
		bFNPCJOMGFL_ = ((other.bFNPCJOMGFL_ != null) ? other.bFNPCJOMGFL_.Clone() : null);
		gAFPECGGICC_ = other.gAFPECGGICC_;
		hasPassed_ = other.hasPassed_;
		dNNHCNCKJCM_ = other.dNNHCNCKJCM_;
		kBHEGBCAAMG_ = other.kBHEGBCAAMG_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BDEMABPLPKO Clone()
	{
		return new BDEMABPLPKO(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BDEMABPLPKO);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BDEMABPLPKO other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!bPCKFLJIGCI_.Equals(other.bPCKFLJIGCI_))
		{
			return false;
		}
		if (CFIONKKIPJL != other.CFIONKKIPJL)
		{
			return false;
		}
		if (!object.Equals(BFNPCJOMGFL, other.BFNPCJOMGFL))
		{
			return false;
		}
		if (GAFPECGGICC != other.GAFPECGGICC)
		{
			return false;
		}
		if (HasPassed != other.HasPassed)
		{
			return false;
		}
		if (DNNHCNCKJCM != other.DNNHCNCKJCM)
		{
			return false;
		}
		if (!KBHEGBCAAMG.Equals(other.KBHEGBCAAMG))
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
		num ^= bPCKFLJIGCI_.GetHashCode();
		if (CFIONKKIPJL)
		{
			num ^= CFIONKKIPJL.GetHashCode();
		}
		if (bFNPCJOMGFL_ != null)
		{
			num ^= BFNPCJOMGFL.GetHashCode();
		}
		if (GAFPECGGICC != 0)
		{
			num ^= GAFPECGGICC.GetHashCode();
		}
		if (HasPassed)
		{
			num ^= HasPassed.GetHashCode();
		}
		if (DNNHCNCKJCM != 0L)
		{
			num ^= DNNHCNCKJCM.GetHashCode();
		}
		num ^= KBHEGBCAAMG.GetHashCode();
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
		bPCKFLJIGCI_.WriteTo(ref output, _repeated_bPCKFLJIGCI_codec);
		if (CFIONKKIPJL)
		{
			output.WriteRawTag(32);
			output.WriteBool(CFIONKKIPJL);
		}
		if (bFNPCJOMGFL_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(BFNPCJOMGFL);
		}
		if (GAFPECGGICC != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(GAFPECGGICC);
		}
		if (HasPassed)
		{
			output.WriteRawTag(72);
			output.WriteBool(HasPassed);
		}
		if (DNNHCNCKJCM != 0L)
		{
			output.WriteRawTag(88);
			output.WriteInt64(DNNHCNCKJCM);
		}
		kBHEGBCAAMG_.WriteTo(ref output, _map_kBHEGBCAAMG_codec);
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
		num += bPCKFLJIGCI_.CalculateSize(_repeated_bPCKFLJIGCI_codec);
		if (CFIONKKIPJL)
		{
			num += 2;
		}
		if (bFNPCJOMGFL_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BFNPCJOMGFL);
		}
		if (GAFPECGGICC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GAFPECGGICC);
		}
		if (HasPassed)
		{
			num += 2;
		}
		if (DNNHCNCKJCM != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(DNNHCNCKJCM);
		}
		num += kBHEGBCAAMG_.CalculateSize(_map_kBHEGBCAAMG_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BDEMABPLPKO other)
	{
		if (other == null)
		{
			return;
		}
		bPCKFLJIGCI_.Add(other.bPCKFLJIGCI_);
		if (other.CFIONKKIPJL)
		{
			CFIONKKIPJL = other.CFIONKKIPJL;
		}
		if (other.bFNPCJOMGFL_ != null)
		{
			if (bFNPCJOMGFL_ == null)
			{
				BFNPCJOMGFL = new EFEGKDHEMFN();
			}
			BFNPCJOMGFL.MergeFrom(other.BFNPCJOMGFL);
		}
		if (other.GAFPECGGICC != 0)
		{
			GAFPECGGICC = other.GAFPECGGICC;
		}
		if (other.HasPassed)
		{
			HasPassed = other.HasPassed;
		}
		if (other.DNNHCNCKJCM != 0L)
		{
			DNNHCNCKJCM = other.DNNHCNCKJCM;
		}
		kBHEGBCAAMG_.MergeFrom(other.kBHEGBCAAMG_);
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
			case 26u:
				bPCKFLJIGCI_.AddEntriesFrom(ref input, _repeated_bPCKFLJIGCI_codec);
				break;
			case 32u:
				CFIONKKIPJL = input.ReadBool();
				break;
			case 42u:
				if (bFNPCJOMGFL_ == null)
				{
					BFNPCJOMGFL = new EFEGKDHEMFN();
				}
				input.ReadMessage(BFNPCJOMGFL);
				break;
			case 48u:
				GAFPECGGICC = input.ReadUInt32();
				break;
			case 72u:
				HasPassed = input.ReadBool();
				break;
			case 88u:
				DNNHCNCKJCM = input.ReadInt64();
				break;
			case 114u:
				kBHEGBCAAMG_.AddEntriesFrom(ref input, _map_kBHEGBCAAMG_codec);
				break;
			}
		}
	}
}
