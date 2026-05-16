using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FIKNLFBIPHK : IMessage<FIKNLFBIPHK>, IMessage, IEquatable<FIKNLFBIPHK>, IDeepCloneable<FIKNLFBIPHK>, IBufferMessage
{
	private static readonly MessageParser<FIKNLFBIPHK> _parser = new MessageParser<FIKNLFBIPHK>(() => new FIKNLFBIPHK());

	private UnknownFieldSet _unknownFields;

	public const int KICMNNPFEGKFieldNumber = 1;

	private uint kICMNNPFEGK_;

	public const int JIFPGDCFDEKFieldNumber = 2;

	private bool jIFPGDCFDEK_;

	public const int EAMDICNBNILFieldNumber = 3;

	private LHJCFNLPFIL eAMDICNBNIL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FIKNLFBIPHK> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FIKNLFBIPHKReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KICMNNPFEGK
	{
		get
		{
			return kICMNNPFEGK_;
		}
		set
		{
			kICMNNPFEGK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool JIFPGDCFDEK
	{
		get
		{
			return jIFPGDCFDEK_;
		}
		set
		{
			jIFPGDCFDEK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LHJCFNLPFIL EAMDICNBNIL
	{
		get
		{
			return eAMDICNBNIL_;
		}
		set
		{
			eAMDICNBNIL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FIKNLFBIPHK()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FIKNLFBIPHK(FIKNLFBIPHK other)
		: this()
	{
		kICMNNPFEGK_ = other.kICMNNPFEGK_;
		jIFPGDCFDEK_ = other.jIFPGDCFDEK_;
		eAMDICNBNIL_ = ((other.eAMDICNBNIL_ != null) ? other.eAMDICNBNIL_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FIKNLFBIPHK Clone()
	{
		return new FIKNLFBIPHK(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FIKNLFBIPHK);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FIKNLFBIPHK other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (KICMNNPFEGK != other.KICMNNPFEGK)
		{
			return false;
		}
		if (JIFPGDCFDEK != other.JIFPGDCFDEK)
		{
			return false;
		}
		if (!object.Equals(EAMDICNBNIL, other.EAMDICNBNIL))
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
		if (KICMNNPFEGK != 0)
		{
			num ^= KICMNNPFEGK.GetHashCode();
		}
		if (JIFPGDCFDEK)
		{
			num ^= JIFPGDCFDEK.GetHashCode();
		}
		if (eAMDICNBNIL_ != null)
		{
			num ^= EAMDICNBNIL.GetHashCode();
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
		if (KICMNNPFEGK != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(KICMNNPFEGK);
		}
		if (JIFPGDCFDEK)
		{
			output.WriteRawTag(16);
			output.WriteBool(JIFPGDCFDEK);
		}
		if (eAMDICNBNIL_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(EAMDICNBNIL);
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
		if (KICMNNPFEGK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KICMNNPFEGK);
		}
		if (JIFPGDCFDEK)
		{
			num += 2;
		}
		if (eAMDICNBNIL_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EAMDICNBNIL);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FIKNLFBIPHK other)
	{
		if (other == null)
		{
			return;
		}
		if (other.KICMNNPFEGK != 0)
		{
			KICMNNPFEGK = other.KICMNNPFEGK;
		}
		if (other.JIFPGDCFDEK)
		{
			JIFPGDCFDEK = other.JIFPGDCFDEK;
		}
		if (other.eAMDICNBNIL_ != null)
		{
			if (eAMDICNBNIL_ == null)
			{
				EAMDICNBNIL = new LHJCFNLPFIL();
			}
			EAMDICNBNIL.MergeFrom(other.EAMDICNBNIL);
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
			case 8u:
				KICMNNPFEGK = input.ReadUInt32();
				break;
			case 16u:
				JIFPGDCFDEK = input.ReadBool();
				break;
			case 26u:
				if (eAMDICNBNIL_ == null)
				{
					EAMDICNBNIL = new LHJCFNLPFIL();
				}
				input.ReadMessage(EAMDICNBNIL);
				break;
			}
		}
	}
}
