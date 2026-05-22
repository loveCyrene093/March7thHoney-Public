using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AFHIHMKCPNF : IMessage<AFHIHMKCPNF>, IMessage, IEquatable<AFHIHMKCPNF>, IDeepCloneable<AFHIHMKCPNF>, IBufferMessage
{
	private static readonly MessageParser<AFHIHMKCPNF> _parser = new MessageParser<AFHIHMKCPNF>(() => new AFHIHMKCPNF());

	private UnknownFieldSet _unknownFields;

	public const int PIGFCAECFCFFieldNumber = 1;

	private uint pIGFCAECFCF_;

	public const int MonsterIdFieldNumber = 2;

	private uint monsterId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AFHIHMKCPNF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AFHIHMKCPNFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PIGFCAECFCF
	{
		get
		{
			return pIGFCAECFCF_;
		}
		set
		{
			pIGFCAECFCF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MonsterId
	{
		get
		{
			return monsterId_;
		}
		set
		{
			monsterId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AFHIHMKCPNF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AFHIHMKCPNF(AFHIHMKCPNF other)
		: this()
	{
		pIGFCAECFCF_ = other.pIGFCAECFCF_;
		monsterId_ = other.monsterId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AFHIHMKCPNF Clone()
	{
		return new AFHIHMKCPNF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AFHIHMKCPNF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AFHIHMKCPNF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PIGFCAECFCF != other.PIGFCAECFCF)
		{
			return false;
		}
		if (MonsterId != other.MonsterId)
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
		if (PIGFCAECFCF != 0)
		{
			num ^= PIGFCAECFCF.GetHashCode();
		}
		if (MonsterId != 0)
		{
			num ^= MonsterId.GetHashCode();
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
		if (PIGFCAECFCF != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(PIGFCAECFCF);
		}
		if (MonsterId != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(MonsterId);
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
		if (PIGFCAECFCF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PIGFCAECFCF);
		}
		if (MonsterId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MonsterId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AFHIHMKCPNF other)
	{
		if (other != null)
		{
			if (other.PIGFCAECFCF != 0)
			{
				PIGFCAECFCF = other.PIGFCAECFCF;
			}
			if (other.MonsterId != 0)
			{
				MonsterId = other.MonsterId;
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
				PIGFCAECFCF = input.ReadUInt32();
				break;
			case 16u:
				MonsterId = input.ReadUInt32();
				break;
			}
		}
	}
}
