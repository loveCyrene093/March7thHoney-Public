using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EBDPCIIFFON : IMessage<EBDPCIIFFON>, IMessage, IEquatable<EBDPCIIFFON>, IDeepCloneable<EBDPCIIFFON>, IBufferMessage
{
	private static readonly MessageParser<EBDPCIIFFON> _parser = new MessageParser<EBDPCIIFFON>(() => new EBDPCIIFFON());

	private UnknownFieldSet _unknownFields;

	public const int HFJDGDIPLAGFieldNumber = 1;

	private bool hFJDGDIPLAG_;

	public const int FNHKNLIJKPIFieldNumber = 8;

	private uint fNHKNLIJKPI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EBDPCIIFFON> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EBDPCIIFFONReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HFJDGDIPLAG
	{
		get
		{
			return hFJDGDIPLAG_;
		}
		set
		{
			hFJDGDIPLAG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FNHKNLIJKPI
	{
		get
		{
			return fNHKNLIJKPI_;
		}
		set
		{
			fNHKNLIJKPI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EBDPCIIFFON()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EBDPCIIFFON(EBDPCIIFFON other)
		: this()
	{
		hFJDGDIPLAG_ = other.hFJDGDIPLAG_;
		fNHKNLIJKPI_ = other.fNHKNLIJKPI_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EBDPCIIFFON Clone()
	{
		return new EBDPCIIFFON(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EBDPCIIFFON);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EBDPCIIFFON other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (HFJDGDIPLAG != other.HFJDGDIPLAG)
		{
			return false;
		}
		if (FNHKNLIJKPI != other.FNHKNLIJKPI)
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
		if (HFJDGDIPLAG)
		{
			num ^= HFJDGDIPLAG.GetHashCode();
		}
		if (FNHKNLIJKPI != 0)
		{
			num ^= FNHKNLIJKPI.GetHashCode();
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
		if (HFJDGDIPLAG)
		{
			output.WriteRawTag(8);
			output.WriteBool(HFJDGDIPLAG);
		}
		if (FNHKNLIJKPI != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(FNHKNLIJKPI);
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
		if (HFJDGDIPLAG)
		{
			num += 2;
		}
		if (FNHKNLIJKPI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FNHKNLIJKPI);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EBDPCIIFFON other)
	{
		if (other != null)
		{
			if (other.HFJDGDIPLAG)
			{
				HFJDGDIPLAG = other.HFJDGDIPLAG;
			}
			if (other.FNHKNLIJKPI != 0)
			{
				FNHKNLIJKPI = other.FNHKNLIJKPI;
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
				HFJDGDIPLAG = input.ReadBool();
				break;
			case 64u:
				FNHKNLIJKPI = input.ReadUInt32();
				break;
			}
		}
	}
}
