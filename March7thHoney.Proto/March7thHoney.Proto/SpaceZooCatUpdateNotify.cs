using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SpaceZooCatUpdateNotify : IMessage<SpaceZooCatUpdateNotify>, IMessage, IEquatable<SpaceZooCatUpdateNotify>, IDeepCloneable<SpaceZooCatUpdateNotify>, IBufferMessage
{
	private static readonly MessageParser<SpaceZooCatUpdateNotify> _parser = new MessageParser<SpaceZooCatUpdateNotify>(() => new SpaceZooCatUpdateNotify());

	private UnknownFieldSet _unknownFields;

	public const int DLAKELOEOOCFieldNumber = 4;

	private bool dLAKELOEOOC_;

	public const int BFALLCGIPOGFieldNumber = 8;

	private bool bFALLCGIPOG_;

	public const int DDLHPDBHGJDFieldNumber = 12;

	private static readonly FieldCodec<LKJMLPJEPGG> _repeated_dDLHPDBHGJD_codec = FieldCodec.ForMessage(98u, LKJMLPJEPGG.Parser);

	private readonly RepeatedField<LKJMLPJEPGG> dDLHPDBHGJD_ = new RepeatedField<LKJMLPJEPGG>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SpaceZooCatUpdateNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SpaceZooCatUpdateNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool DLAKELOEOOC
	{
		get
		{
			return dLAKELOEOOC_;
		}
		set
		{
			dLAKELOEOOC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool BFALLCGIPOG
	{
		get
		{
			return bFALLCGIPOG_;
		}
		set
		{
			bFALLCGIPOG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<LKJMLPJEPGG> DDLHPDBHGJD => dDLHPDBHGJD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SpaceZooCatUpdateNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SpaceZooCatUpdateNotify(SpaceZooCatUpdateNotify other)
		: this()
	{
		dLAKELOEOOC_ = other.dLAKELOEOOC_;
		bFALLCGIPOG_ = other.bFALLCGIPOG_;
		dDLHPDBHGJD_ = other.dDLHPDBHGJD_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SpaceZooCatUpdateNotify Clone()
	{
		return new SpaceZooCatUpdateNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SpaceZooCatUpdateNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SpaceZooCatUpdateNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DLAKELOEOOC != other.DLAKELOEOOC)
		{
			return false;
		}
		if (BFALLCGIPOG != other.BFALLCGIPOG)
		{
			return false;
		}
		if (!dDLHPDBHGJD_.Equals(other.dDLHPDBHGJD_))
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
		if (DLAKELOEOOC)
		{
			num ^= DLAKELOEOOC.GetHashCode();
		}
		if (BFALLCGIPOG)
		{
			num ^= BFALLCGIPOG.GetHashCode();
		}
		num ^= dDLHPDBHGJD_.GetHashCode();
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
		if (DLAKELOEOOC)
		{
			output.WriteRawTag(32);
			output.WriteBool(DLAKELOEOOC);
		}
		if (BFALLCGIPOG)
		{
			output.WriteRawTag(64);
			output.WriteBool(BFALLCGIPOG);
		}
		dDLHPDBHGJD_.WriteTo(ref output, _repeated_dDLHPDBHGJD_codec);
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
		if (DLAKELOEOOC)
		{
			num += 2;
		}
		if (BFALLCGIPOG)
		{
			num += 2;
		}
		num += dDLHPDBHGJD_.CalculateSize(_repeated_dDLHPDBHGJD_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SpaceZooCatUpdateNotify other)
	{
		if (other != null)
		{
			if (other.DLAKELOEOOC)
			{
				DLAKELOEOOC = other.DLAKELOEOOC;
			}
			if (other.BFALLCGIPOG)
			{
				BFALLCGIPOG = other.BFALLCGIPOG;
			}
			dDLHPDBHGJD_.Add(other.dDLHPDBHGJD_);
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
				DLAKELOEOOC = input.ReadBool();
				break;
			case 64u:
				BFALLCGIPOG = input.ReadBool();
				break;
			case 98u:
				dDLHPDBHGJD_.AddEntriesFrom(ref input, _repeated_dDLHPDBHGJD_codec);
				break;
			}
		}
	}
}
