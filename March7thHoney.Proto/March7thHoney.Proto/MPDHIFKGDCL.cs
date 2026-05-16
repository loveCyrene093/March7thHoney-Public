using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MPDHIFKGDCL : IMessage<MPDHIFKGDCL>, IMessage, IEquatable<MPDHIFKGDCL>, IDeepCloneable<MPDHIFKGDCL>, IBufferMessage
{
	private static readonly MessageParser<MPDHIFKGDCL> _parser = new MessageParser<MPDHIFKGDCL>(() => new MPDHIFKGDCL());

	private UnknownFieldSet _unknownFields;

	public const int IEMPGPCNAAHFieldNumber = 1;

	private uint iEMPGPCNAAH_;

	public const int ProgressFieldNumber = 6;

	private uint progress_;

	public const int KBKLMLKDNMPFieldNumber = 9;

	private uint kBKLMLKDNMP_;

	public const int HasPassedFieldNumber = 13;

	private bool hasPassed_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MPDHIFKGDCL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MPDHIFKGDCLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IEMPGPCNAAH
	{
		get
		{
			return iEMPGPCNAAH_;
		}
		set
		{
			iEMPGPCNAAH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Progress
	{
		get
		{
			return progress_;
		}
		set
		{
			progress_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KBKLMLKDNMP
	{
		get
		{
			return kBKLMLKDNMP_;
		}
		set
		{
			kBKLMLKDNMP_ = value;
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
	public MPDHIFKGDCL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MPDHIFKGDCL(MPDHIFKGDCL other)
		: this()
	{
		iEMPGPCNAAH_ = other.iEMPGPCNAAH_;
		progress_ = other.progress_;
		kBKLMLKDNMP_ = other.kBKLMLKDNMP_;
		hasPassed_ = other.hasPassed_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MPDHIFKGDCL Clone()
	{
		return new MPDHIFKGDCL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MPDHIFKGDCL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MPDHIFKGDCL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IEMPGPCNAAH != other.IEMPGPCNAAH)
		{
			return false;
		}
		if (Progress != other.Progress)
		{
			return false;
		}
		if (KBKLMLKDNMP != other.KBKLMLKDNMP)
		{
			return false;
		}
		if (HasPassed != other.HasPassed)
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
		if (IEMPGPCNAAH != 0)
		{
			num ^= IEMPGPCNAAH.GetHashCode();
		}
		if (Progress != 0)
		{
			num ^= Progress.GetHashCode();
		}
		if (KBKLMLKDNMP != 0)
		{
			num ^= KBKLMLKDNMP.GetHashCode();
		}
		if (HasPassed)
		{
			num ^= HasPassed.GetHashCode();
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
		if (IEMPGPCNAAH != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(IEMPGPCNAAH);
		}
		if (Progress != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(Progress);
		}
		if (KBKLMLKDNMP != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(KBKLMLKDNMP);
		}
		if (HasPassed)
		{
			output.WriteRawTag(104);
			output.WriteBool(HasPassed);
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
		if (IEMPGPCNAAH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IEMPGPCNAAH);
		}
		if (Progress != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Progress);
		}
		if (KBKLMLKDNMP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KBKLMLKDNMP);
		}
		if (HasPassed)
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
	public void MergeFrom(MPDHIFKGDCL other)
	{
		if (other != null)
		{
			if (other.IEMPGPCNAAH != 0)
			{
				IEMPGPCNAAH = other.IEMPGPCNAAH;
			}
			if (other.Progress != 0)
			{
				Progress = other.Progress;
			}
			if (other.KBKLMLKDNMP != 0)
			{
				KBKLMLKDNMP = other.KBKLMLKDNMP;
			}
			if (other.HasPassed)
			{
				HasPassed = other.HasPassed;
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
			case 8u:
				IEMPGPCNAAH = input.ReadUInt32();
				break;
			case 48u:
				Progress = input.ReadUInt32();
				break;
			case 72u:
				KBKLMLKDNMP = input.ReadUInt32();
				break;
			case 104u:
				HasPassed = input.ReadBool();
				break;
			}
		}
	}
}
