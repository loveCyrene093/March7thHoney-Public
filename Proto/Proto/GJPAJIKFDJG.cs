using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GJPAJIKFDJG : IMessage<GJPAJIKFDJG>, IMessage, IEquatable<GJPAJIKFDJG>, IDeepCloneable<GJPAJIKFDJG>, IBufferMessage
{
	private static readonly MessageParser<GJPAJIKFDJG> _parser = new MessageParser<GJPAJIKFDJG>(() => new GJPAJIKFDJG());

	private UnknownFieldSet _unknownFields;

	public const int CAFOKMNABHNFieldNumber = 1;

	private HHAGKIHIMFB cAFOKMNABHN_;

	public const int KHAJDKDHPGDFieldNumber = 4;

	private ulong kHAJDKDHPGD_;

	public const int HMNHNAJJCKEFieldNumber = 5;

	private AOIKHPOBDGK hMNHNAJJCKE_;

	public const int KGKOHNAACENFieldNumber = 12;

	private HHOKEJLGOBN kGKOHNAACEN_;

	public const int HGHJJHNBGCMFieldNumber = 15;

	private ulong hGHJJHNBGCM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GJPAJIKFDJG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GJPAJIKFDJGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HHAGKIHIMFB CAFOKMNABHN
	{
		get
		{
			return cAFOKMNABHN_;
		}
		set
		{
			cAFOKMNABHN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong KHAJDKDHPGD
	{
		get
		{
			return kHAJDKDHPGD_;
		}
		set
		{
			kHAJDKDHPGD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AOIKHPOBDGK HMNHNAJJCKE
	{
		get
		{
			return hMNHNAJJCKE_;
		}
		set
		{
			hMNHNAJJCKE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HHOKEJLGOBN KGKOHNAACEN
	{
		get
		{
			return kGKOHNAACEN_;
		}
		set
		{
			kGKOHNAACEN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong HGHJJHNBGCM
	{
		get
		{
			return hGHJJHNBGCM_;
		}
		set
		{
			hGHJJHNBGCM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GJPAJIKFDJG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GJPAJIKFDJG(GJPAJIKFDJG other)
		: this()
	{
		cAFOKMNABHN_ = ((other.cAFOKMNABHN_ != null) ? other.cAFOKMNABHN_.Clone() : null);
		kHAJDKDHPGD_ = other.kHAJDKDHPGD_;
		hMNHNAJJCKE_ = ((other.hMNHNAJJCKE_ != null) ? other.hMNHNAJJCKE_.Clone() : null);
		kGKOHNAACEN_ = ((other.kGKOHNAACEN_ != null) ? other.kGKOHNAACEN_.Clone() : null);
		hGHJJHNBGCM_ = other.hGHJJHNBGCM_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GJPAJIKFDJG Clone()
	{
		return new GJPAJIKFDJG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GJPAJIKFDJG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GJPAJIKFDJG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(CAFOKMNABHN, other.CAFOKMNABHN))
		{
			return false;
		}
		if (KHAJDKDHPGD != other.KHAJDKDHPGD)
		{
			return false;
		}
		if (!object.Equals(HMNHNAJJCKE, other.HMNHNAJJCKE))
		{
			return false;
		}
		if (!object.Equals(KGKOHNAACEN, other.KGKOHNAACEN))
		{
			return false;
		}
		if (HGHJJHNBGCM != other.HGHJJHNBGCM)
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
		if (cAFOKMNABHN_ != null)
		{
			num ^= CAFOKMNABHN.GetHashCode();
		}
		if (KHAJDKDHPGD != 0L)
		{
			num ^= KHAJDKDHPGD.GetHashCode();
		}
		if (hMNHNAJJCKE_ != null)
		{
			num ^= HMNHNAJJCKE.GetHashCode();
		}
		if (kGKOHNAACEN_ != null)
		{
			num ^= KGKOHNAACEN.GetHashCode();
		}
		if (HGHJJHNBGCM != 0L)
		{
			num ^= HGHJJHNBGCM.GetHashCode();
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
		if (cAFOKMNABHN_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(CAFOKMNABHN);
		}
		if (KHAJDKDHPGD != 0L)
		{
			output.WriteRawTag(32);
			output.WriteUInt64(KHAJDKDHPGD);
		}
		if (hMNHNAJJCKE_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(HMNHNAJJCKE);
		}
		if (kGKOHNAACEN_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(KGKOHNAACEN);
		}
		if (HGHJJHNBGCM != 0L)
		{
			output.WriteRawTag(120);
			output.WriteUInt64(HGHJJHNBGCM);
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
		if (cAFOKMNABHN_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CAFOKMNABHN);
		}
		if (KHAJDKDHPGD != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(KHAJDKDHPGD);
		}
		if (hMNHNAJJCKE_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HMNHNAJJCKE);
		}
		if (kGKOHNAACEN_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(KGKOHNAACEN);
		}
		if (HGHJJHNBGCM != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(HGHJJHNBGCM);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GJPAJIKFDJG other)
	{
		if (other == null)
		{
			return;
		}
		if (other.cAFOKMNABHN_ != null)
		{
			if (cAFOKMNABHN_ == null)
			{
				CAFOKMNABHN = new HHAGKIHIMFB();
			}
			CAFOKMNABHN.MergeFrom(other.CAFOKMNABHN);
		}
		if (other.KHAJDKDHPGD != 0L)
		{
			KHAJDKDHPGD = other.KHAJDKDHPGD;
		}
		if (other.hMNHNAJJCKE_ != null)
		{
			if (hMNHNAJJCKE_ == null)
			{
				HMNHNAJJCKE = new AOIKHPOBDGK();
			}
			HMNHNAJJCKE.MergeFrom(other.HMNHNAJJCKE);
		}
		if (other.kGKOHNAACEN_ != null)
		{
			if (kGKOHNAACEN_ == null)
			{
				KGKOHNAACEN = new HHOKEJLGOBN();
			}
			KGKOHNAACEN.MergeFrom(other.KGKOHNAACEN);
		}
		if (other.HGHJJHNBGCM != 0L)
		{
			HGHJJHNBGCM = other.HGHJJHNBGCM;
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
			case 10u:
				if (cAFOKMNABHN_ == null)
				{
					CAFOKMNABHN = new HHAGKIHIMFB();
				}
				input.ReadMessage(CAFOKMNABHN);
				break;
			case 32u:
				KHAJDKDHPGD = input.ReadUInt64();
				break;
			case 42u:
				if (hMNHNAJJCKE_ == null)
				{
					HMNHNAJJCKE = new AOIKHPOBDGK();
				}
				input.ReadMessage(HMNHNAJJCKE);
				break;
			case 98u:
				if (kGKOHNAACEN_ == null)
				{
					KGKOHNAACEN = new HHOKEJLGOBN();
				}
				input.ReadMessage(KGKOHNAACEN);
				break;
			case 120u:
				HGHJJHNBGCM = input.ReadUInt64();
				break;
			}
		}
	}
}
