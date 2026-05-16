using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NGJPJANLDHI : IMessage<NGJPJANLDHI>, IMessage, IEquatable<NGJPJANLDHI>, IDeepCloneable<NGJPJANLDHI>, IBufferMessage
{
	private static readonly MessageParser<NGJPJANLDHI> _parser = new MessageParser<NGJPJANLDHI>(() => new NGJPJANLDHI());

	private UnknownFieldSet _unknownFields;

	public const int FHDPEMCABIEFieldNumber = 1;

	private uint fHDPEMCABIE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NGJPJANLDHI> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NGJPJANLDHIReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FHDPEMCABIE
	{
		get
		{
			return fHDPEMCABIE_;
		}
		set
		{
			fHDPEMCABIE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NGJPJANLDHI()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NGJPJANLDHI(NGJPJANLDHI other)
		: this()
	{
		fHDPEMCABIE_ = other.fHDPEMCABIE_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NGJPJANLDHI Clone()
	{
		return new NGJPJANLDHI(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NGJPJANLDHI);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NGJPJANLDHI other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (FHDPEMCABIE != other.FHDPEMCABIE)
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
		if (FHDPEMCABIE != 0)
		{
			num ^= FHDPEMCABIE.GetHashCode();
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
		if (FHDPEMCABIE != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(FHDPEMCABIE);
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
		if (FHDPEMCABIE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FHDPEMCABIE);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NGJPJANLDHI other)
	{
		if (other != null)
		{
			if (other.FHDPEMCABIE != 0)
			{
				FHDPEMCABIE = other.FHDPEMCABIE;
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
			if (num != 8)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				FHDPEMCABIE = input.ReadUInt32();
			}
		}
	}
}
