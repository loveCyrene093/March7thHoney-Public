using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EPJMBDHODLE : IMessage<EPJMBDHODLE>, IMessage, IEquatable<EPJMBDHODLE>, IDeepCloneable<EPJMBDHODLE>, IBufferMessage
{
	private static readonly MessageParser<EPJMBDHODLE> _parser = new MessageParser<EPJMBDHODLE>(() => new EPJMBDHODLE());

	private UnknownFieldSet _unknownFields;

	public const int EFDDNMGLANFFieldNumber = 4;

	private uint eFDDNMGLANF_;

	public const int IsWinFieldNumber = 6;

	private bool isWin_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EPJMBDHODLE> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EPJMBDHODLEReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EFDDNMGLANF
	{
		get
		{
			return eFDDNMGLANF_;
		}
		set
		{
			eFDDNMGLANF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsWin
	{
		get
		{
			return isWin_;
		}
		set
		{
			isWin_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EPJMBDHODLE()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EPJMBDHODLE(EPJMBDHODLE other)
		: this()
	{
		eFDDNMGLANF_ = other.eFDDNMGLANF_;
		isWin_ = other.isWin_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EPJMBDHODLE Clone()
	{
		return new EPJMBDHODLE(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EPJMBDHODLE);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EPJMBDHODLE other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EFDDNMGLANF != other.EFDDNMGLANF)
		{
			return false;
		}
		if (IsWin != other.IsWin)
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
		if (EFDDNMGLANF != 0)
		{
			num ^= EFDDNMGLANF.GetHashCode();
		}
		if (IsWin)
		{
			num ^= IsWin.GetHashCode();
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
		if (EFDDNMGLANF != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(EFDDNMGLANF);
		}
		if (IsWin)
		{
			output.WriteRawTag(48);
			output.WriteBool(IsWin);
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
		if (EFDDNMGLANF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EFDDNMGLANF);
		}
		if (IsWin)
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
	public void MergeFrom(EPJMBDHODLE other)
	{
		if (other != null)
		{
			if (other.EFDDNMGLANF != 0)
			{
				EFDDNMGLANF = other.EFDDNMGLANF;
			}
			if (other.IsWin)
			{
				IsWin = other.IsWin;
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
			case 32u:
				EFDDNMGLANF = input.ReadUInt32();
				break;
			case 48u:
				IsWin = input.ReadBool();
				break;
			}
		}
	}
}
