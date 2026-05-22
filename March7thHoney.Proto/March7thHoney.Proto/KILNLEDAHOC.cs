using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KILNLEDAHOC : IMessage<KILNLEDAHOC>, IMessage, IEquatable<KILNLEDAHOC>, IDeepCloneable<KILNLEDAHOC>, IBufferMessage
{
	private static readonly MessageParser<KILNLEDAHOC> _parser = new MessageParser<KILNLEDAHOC>(() => new KILNLEDAHOC());

	private UnknownFieldSet _unknownFields;

	public const int AIPIHJLCIHAFieldNumber = 5;

	private uint aIPIHJLCIHA_;

	public const int HEIHGFAOFNKFieldNumber = 13;

	private uint hEIHGFAOFNK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KILNLEDAHOC> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KILNLEDAHOCReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AIPIHJLCIHA
	{
		get
		{
			return aIPIHJLCIHA_;
		}
		set
		{
			aIPIHJLCIHA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HEIHGFAOFNK
	{
		get
		{
			return hEIHGFAOFNK_;
		}
		set
		{
			hEIHGFAOFNK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KILNLEDAHOC()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KILNLEDAHOC(KILNLEDAHOC other)
		: this()
	{
		aIPIHJLCIHA_ = other.aIPIHJLCIHA_;
		hEIHGFAOFNK_ = other.hEIHGFAOFNK_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KILNLEDAHOC Clone()
	{
		return new KILNLEDAHOC(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as KILNLEDAHOC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KILNLEDAHOC other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AIPIHJLCIHA != other.AIPIHJLCIHA)
		{
			return false;
		}
		if (HEIHGFAOFNK != other.HEIHGFAOFNK)
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
		if (AIPIHJLCIHA != 0)
		{
			num ^= AIPIHJLCIHA.GetHashCode();
		}
		if (HEIHGFAOFNK != 0)
		{
			num ^= HEIHGFAOFNK.GetHashCode();
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
		if (AIPIHJLCIHA != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(AIPIHJLCIHA);
		}
		if (HEIHGFAOFNK != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(HEIHGFAOFNK);
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
		if (AIPIHJLCIHA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AIPIHJLCIHA);
		}
		if (HEIHGFAOFNK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HEIHGFAOFNK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(KILNLEDAHOC other)
	{
		if (other != null)
		{
			if (other.AIPIHJLCIHA != 0)
			{
				AIPIHJLCIHA = other.AIPIHJLCIHA;
			}
			if (other.HEIHGFAOFNK != 0)
			{
				HEIHGFAOFNK = other.HEIHGFAOFNK;
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
			case 40u:
				AIPIHJLCIHA = input.ReadUInt32();
				break;
			case 104u:
				HEIHGFAOFNK = input.ReadUInt32();
				break;
			}
		}
	}
}
