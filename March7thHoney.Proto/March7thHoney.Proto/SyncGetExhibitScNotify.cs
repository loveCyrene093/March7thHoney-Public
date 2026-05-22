using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SyncGetExhibitScNotify : IMessage<SyncGetExhibitScNotify>, IMessage, IEquatable<SyncGetExhibitScNotify>, IDeepCloneable<SyncGetExhibitScNotify>, IBufferMessage
{
	private static readonly MessageParser<SyncGetExhibitScNotify> _parser = new MessageParser<SyncGetExhibitScNotify>(() => new SyncGetExhibitScNotify());

	private UnknownFieldSet _unknownFields;

	public const int ECJBEELEDFKFieldNumber = 3;

	private uint eCJBEELEDFK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SyncGetExhibitScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SyncGetExhibitScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ECJBEELEDFK
	{
		get
		{
			return eCJBEELEDFK_;
		}
		set
		{
			eCJBEELEDFK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncGetExhibitScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncGetExhibitScNotify(SyncGetExhibitScNotify other)
		: this()
	{
		eCJBEELEDFK_ = other.eCJBEELEDFK_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncGetExhibitScNotify Clone()
	{
		return new SyncGetExhibitScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SyncGetExhibitScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SyncGetExhibitScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ECJBEELEDFK != other.ECJBEELEDFK)
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
		if (ECJBEELEDFK != 0)
		{
			num ^= ECJBEELEDFK.GetHashCode();
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
		if (ECJBEELEDFK != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(ECJBEELEDFK);
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
		if (ECJBEELEDFK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ECJBEELEDFK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SyncGetExhibitScNotify other)
	{
		if (other != null)
		{
			if (other.ECJBEELEDFK != 0)
			{
				ECJBEELEDFK = other.ECJBEELEDFK;
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
			if (num != 24)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				ECJBEELEDFK = input.ReadUInt32();
			}
		}
	}
}
