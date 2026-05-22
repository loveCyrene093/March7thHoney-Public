using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DPBGGKCMLGM : IMessage<DPBGGKCMLGM>, IMessage, IEquatable<DPBGGKCMLGM>, IDeepCloneable<DPBGGKCMLGM>, IBufferMessage
{
	private static readonly MessageParser<DPBGGKCMLGM> _parser = new MessageParser<DPBGGKCMLGM>(() => new DPBGGKCMLGM());

	private UnknownFieldSet _unknownFields;

	public const int ProgressFieldNumber = 1;

	private uint progress_;

	public const int BFEKDNEBDKPFieldNumber = 7;

	private uint bFEKDNEBDKP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DPBGGKCMLGM> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DPBGGKCMLGMReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public uint BFEKDNEBDKP
	{
		get
		{
			return bFEKDNEBDKP_;
		}
		set
		{
			bFEKDNEBDKP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DPBGGKCMLGM()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DPBGGKCMLGM(DPBGGKCMLGM other)
		: this()
	{
		progress_ = other.progress_;
		bFEKDNEBDKP_ = other.bFEKDNEBDKP_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DPBGGKCMLGM Clone()
	{
		return new DPBGGKCMLGM(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DPBGGKCMLGM);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DPBGGKCMLGM other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Progress != other.Progress)
		{
			return false;
		}
		if (BFEKDNEBDKP != other.BFEKDNEBDKP)
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
		if (Progress != 0)
		{
			num ^= Progress.GetHashCode();
		}
		if (BFEKDNEBDKP != 0)
		{
			num ^= BFEKDNEBDKP.GetHashCode();
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
		if (Progress != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(Progress);
		}
		if (BFEKDNEBDKP != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(BFEKDNEBDKP);
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
		if (Progress != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Progress);
		}
		if (BFEKDNEBDKP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BFEKDNEBDKP);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DPBGGKCMLGM other)
	{
		if (other != null)
		{
			if (other.Progress != 0)
			{
				Progress = other.Progress;
			}
			if (other.BFEKDNEBDKP != 0)
			{
				BFEKDNEBDKP = other.BFEKDNEBDKP;
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
				Progress = input.ReadUInt32();
				break;
			case 56u:
				BFEKDNEBDKP = input.ReadUInt32();
				break;
			}
		}
	}
}
