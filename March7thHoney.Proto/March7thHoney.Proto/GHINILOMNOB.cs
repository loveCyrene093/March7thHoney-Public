using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GHINILOMNOB : IMessage<GHINILOMNOB>, IMessage, IEquatable<GHINILOMNOB>, IDeepCloneable<GHINILOMNOB>, IBufferMessage
{
	private static readonly MessageParser<GHINILOMNOB> _parser = new MessageParser<GHINILOMNOB>(() => new GHINILOMNOB());

	private UnknownFieldSet _unknownFields;

	public const int HANNDMGHBEOFieldNumber = 4;

	private uint hANNDMGHBEO_;

	public const int MIHBADEPGIDFieldNumber = 6;

	private uint mIHBADEPGID_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GHINILOMNOB> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GHINILOMNOBReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HANNDMGHBEO
	{
		get
		{
			return hANNDMGHBEO_;
		}
		set
		{
			hANNDMGHBEO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MIHBADEPGID
	{
		get
		{
			return mIHBADEPGID_;
		}
		set
		{
			mIHBADEPGID_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GHINILOMNOB()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GHINILOMNOB(GHINILOMNOB other)
		: this()
	{
		hANNDMGHBEO_ = other.hANNDMGHBEO_;
		mIHBADEPGID_ = other.mIHBADEPGID_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GHINILOMNOB Clone()
	{
		return new GHINILOMNOB(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GHINILOMNOB);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GHINILOMNOB other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (HANNDMGHBEO != other.HANNDMGHBEO)
		{
			return false;
		}
		if (MIHBADEPGID != other.MIHBADEPGID)
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
		if (HANNDMGHBEO != 0)
		{
			num ^= HANNDMGHBEO.GetHashCode();
		}
		if (MIHBADEPGID != 0)
		{
			num ^= MIHBADEPGID.GetHashCode();
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
		if (HANNDMGHBEO != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(HANNDMGHBEO);
		}
		if (MIHBADEPGID != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(MIHBADEPGID);
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
		if (HANNDMGHBEO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HANNDMGHBEO);
		}
		if (MIHBADEPGID != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MIHBADEPGID);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GHINILOMNOB other)
	{
		if (other != null)
		{
			if (other.HANNDMGHBEO != 0)
			{
				HANNDMGHBEO = other.HANNDMGHBEO;
			}
			if (other.MIHBADEPGID != 0)
			{
				MIHBADEPGID = other.MIHBADEPGID;
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
				HANNDMGHBEO = input.ReadUInt32();
				break;
			case 48u:
				MIHBADEPGID = input.ReadUInt32();
				break;
			}
		}
	}
}
