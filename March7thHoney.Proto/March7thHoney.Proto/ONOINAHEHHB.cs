using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ONOINAHEHHB : IMessage<ONOINAHEHHB>, IMessage, IEquatable<ONOINAHEHHB>, IDeepCloneable<ONOINAHEHHB>, IBufferMessage
{
	private static readonly MessageParser<ONOINAHEHHB> _parser = new MessageParser<ONOINAHEHHB>(() => new ONOINAHEHHB());

	private UnknownFieldSet _unknownFields;

	public const int GAFPECGGICCFieldNumber = 3;

	private uint gAFPECGGICC_;

	public const int MNPCBLEHGHPFieldNumber = 4;

	private uint mNPCBLEHGHP_;

	public const int LJMMOMIHGEIFieldNumber = 5;

	private EFEGKDHEMFN lJMMOMIHGEI_;

	public const int BFNPCJOMGFLFieldNumber = 6;

	private EFEGKDHEMFN bFNPCJOMGFL_;

	public const int MMNOLIMBPCAFieldNumber = 11;

	private static readonly FieldCodec<CNLIKADPCBH> _repeated_mMNOLIMBPCA_codec = FieldCodec.ForMessage(90u, CNLIKADPCBH.Parser);

	private readonly RepeatedField<CNLIKADPCBH> mMNOLIMBPCA_ = new RepeatedField<CNLIKADPCBH>();

	public const int CFIONKKIPJLFieldNumber = 12;

	private bool cFIONKKIPJL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ONOINAHEHHB> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ONOINAHEHHBReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public uint MNPCBLEHGHP
	{
		get
		{
			return mNPCBLEHGHP_;
		}
		set
		{
			mNPCBLEHGHP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EFEGKDHEMFN LJMMOMIHGEI
	{
		get
		{
			return lJMMOMIHGEI_;
		}
		set
		{
			lJMMOMIHGEI_ = value;
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
	public RepeatedField<CNLIKADPCBH> MMNOLIMBPCA => mMNOLIMBPCA_;

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
	public ONOINAHEHHB()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ONOINAHEHHB(ONOINAHEHHB other)
		: this()
	{
		gAFPECGGICC_ = other.gAFPECGGICC_;
		mNPCBLEHGHP_ = other.mNPCBLEHGHP_;
		lJMMOMIHGEI_ = ((other.lJMMOMIHGEI_ != null) ? other.lJMMOMIHGEI_.Clone() : null);
		bFNPCJOMGFL_ = ((other.bFNPCJOMGFL_ != null) ? other.bFNPCJOMGFL_.Clone() : null);
		mMNOLIMBPCA_ = other.mMNOLIMBPCA_.Clone();
		cFIONKKIPJL_ = other.cFIONKKIPJL_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ONOINAHEHHB Clone()
	{
		return new ONOINAHEHHB(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ONOINAHEHHB);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ONOINAHEHHB other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (GAFPECGGICC != other.GAFPECGGICC)
		{
			return false;
		}
		if (MNPCBLEHGHP != other.MNPCBLEHGHP)
		{
			return false;
		}
		if (!object.Equals(LJMMOMIHGEI, other.LJMMOMIHGEI))
		{
			return false;
		}
		if (!object.Equals(BFNPCJOMGFL, other.BFNPCJOMGFL))
		{
			return false;
		}
		if (!mMNOLIMBPCA_.Equals(other.mMNOLIMBPCA_))
		{
			return false;
		}
		if (CFIONKKIPJL != other.CFIONKKIPJL)
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
		if (GAFPECGGICC != 0)
		{
			num ^= GAFPECGGICC.GetHashCode();
		}
		if (MNPCBLEHGHP != 0)
		{
			num ^= MNPCBLEHGHP.GetHashCode();
		}
		if (lJMMOMIHGEI_ != null)
		{
			num ^= LJMMOMIHGEI.GetHashCode();
		}
		if (bFNPCJOMGFL_ != null)
		{
			num ^= BFNPCJOMGFL.GetHashCode();
		}
		num ^= mMNOLIMBPCA_.GetHashCode();
		if (CFIONKKIPJL)
		{
			num ^= CFIONKKIPJL.GetHashCode();
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
		if (GAFPECGGICC != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(GAFPECGGICC);
		}
		if (MNPCBLEHGHP != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(MNPCBLEHGHP);
		}
		if (lJMMOMIHGEI_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(LJMMOMIHGEI);
		}
		if (bFNPCJOMGFL_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(BFNPCJOMGFL);
		}
		mMNOLIMBPCA_.WriteTo(ref output, _repeated_mMNOLIMBPCA_codec);
		if (CFIONKKIPJL)
		{
			output.WriteRawTag(96);
			output.WriteBool(CFIONKKIPJL);
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
		if (GAFPECGGICC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GAFPECGGICC);
		}
		if (MNPCBLEHGHP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MNPCBLEHGHP);
		}
		if (lJMMOMIHGEI_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LJMMOMIHGEI);
		}
		if (bFNPCJOMGFL_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BFNPCJOMGFL);
		}
		num += mMNOLIMBPCA_.CalculateSize(_repeated_mMNOLIMBPCA_codec);
		if (CFIONKKIPJL)
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
	public void MergeFrom(ONOINAHEHHB other)
	{
		if (other == null)
		{
			return;
		}
		if (other.GAFPECGGICC != 0)
		{
			GAFPECGGICC = other.GAFPECGGICC;
		}
		if (other.MNPCBLEHGHP != 0)
		{
			MNPCBLEHGHP = other.MNPCBLEHGHP;
		}
		if (other.lJMMOMIHGEI_ != null)
		{
			if (lJMMOMIHGEI_ == null)
			{
				LJMMOMIHGEI = new EFEGKDHEMFN();
			}
			LJMMOMIHGEI.MergeFrom(other.LJMMOMIHGEI);
		}
		if (other.bFNPCJOMGFL_ != null)
		{
			if (bFNPCJOMGFL_ == null)
			{
				BFNPCJOMGFL = new EFEGKDHEMFN();
			}
			BFNPCJOMGFL.MergeFrom(other.BFNPCJOMGFL);
		}
		mMNOLIMBPCA_.Add(other.mMNOLIMBPCA_);
		if (other.CFIONKKIPJL)
		{
			CFIONKKIPJL = other.CFIONKKIPJL;
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
			case 24u:
				GAFPECGGICC = input.ReadUInt32();
				break;
			case 32u:
				MNPCBLEHGHP = input.ReadUInt32();
				break;
			case 42u:
				if (lJMMOMIHGEI_ == null)
				{
					LJMMOMIHGEI = new EFEGKDHEMFN();
				}
				input.ReadMessage(LJMMOMIHGEI);
				break;
			case 50u:
				if (bFNPCJOMGFL_ == null)
				{
					BFNPCJOMGFL = new EFEGKDHEMFN();
				}
				input.ReadMessage(BFNPCJOMGFL);
				break;
			case 90u:
				mMNOLIMBPCA_.AddEntriesFrom(ref input, _repeated_mMNOLIMBPCA_codec);
				break;
			case 96u:
				CFIONKKIPJL = input.ReadBool();
				break;
			}
		}
	}
}
